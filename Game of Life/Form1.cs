using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // The array sizes
        const int _X = 5;
        const int _Y = 5;

        // The arrays
        bool[,] universe = new bool[_X, _Y];
        bool[,] scratchPad = new bool[_X, _Y];
        bool[,] original = new bool[_X, _Y];
        int[,] neighbors = new int[_X, _Y];

        // Variables for randomizing the seed and the grid
        static int seedInt = 2019;
        Random rand;

        // Variables for toggling the view functions
        bool gridDisplay = true;
        bool neighborDisplay = true;
        bool hudDisplay = true;
        bool finite = false;

        // Writing out neighbors for all cells
        Font font = new Font("Arial", 10f);

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;
        Color livingNumberColor = Color.White;
        Color deadNumberColor = Color.Black;

        // The Timer class
        Timer timer = new Timer();

        // Generation and living cell counts
        int generations = 0;
        int livingCells = 0;

        // The constructor
        public Form1()
        {
            InitializeComponent();

            //Change the name of the Forms window
            this.Text = Properties.Resources.AppTitle;

            // Setup the timer
            timer.Interval = 100; // milliseconds (no lower than 20 to see changes)
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer as not running

            // Read settings
            graphicsPanel1.BackColor = Properties.Settings.Default.GraphicsPanel1_Backcolor;
            gridColor = Properties.Settings.Default.GraphicsPanel1_Gridcolor;
            cellColor = Properties.Settings.Default.GraphicsPanel1_SelectedBoxColor;
            livingNumberColor = Properties.Settings.Default.GraphicsPanel1_SelectedCellNumberColor;
            deadNumberColor = Properties.Settings.Default.GraphicsPanel1_UnselectedCellNumberColor;
            timer.Interval = Properties.Settings.Default.Form1_TimerInterval;
            ResizeArray(ref universe, Properties.Settings.Default.Form1_UniverseRows, Properties.Settings.Default.Form1_UniverseColumns);
            ResizeArray(ref scratchPad, Properties.Settings.Default.Form1_UniverseRows, Properties.Settings.Default.Form1_UniverseColumns);
            ResizeArray(ref neighbors, Properties.Settings.Default.Form1_UniverseRows, Properties.Settings.Default.Form1_UniverseColumns);
            ResizeArray(ref original, Properties.Settings.Default.Form1_UniverseRows, Properties.Settings.Default.Form1_UniverseColumns);
        }

        // Resizing a 2D array 
        private void ResizeArray<T>(ref T[,] ogArray, int newRows, int newCols)
        {
            var newArray = new T[newRows, newCols];
            int minRows = Math.Min(newRows, ogArray.GetLength(1));
            int minCols = Math.Min(newCols, ogArray.GetLength(0));

            for (int x = 0; x < minCols; x++)
            {
                for (int y = 0; y < minRows; y++)
                {
                    newArray[x, y] = ogArray[x, y];
                }
            }

            T[,] temp = ogArray;
            ogArray = newArray;
            newArray = temp;
        }

        // Count living cells in the window
        private void CountLivingCells()
        {
            livingCells = 0;

            for (int x = 0; x < _X; x++)
            {
                for (int y = 0; y < _X; y++)
                {
                    if (universe[x, y] == true)
                    {
                        livingCells++;
                    }
                }
            }
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            //Apply the rules to the universe
            scratchPad = ApplyRules();
            universe = scratchPad;

            graphicsPanel1.Invalidate();

            // Increment generation count
            generations++;

            // Update status strip
            generationsToolStripStatusLabel.Text = "Generations = " + generations.ToString();

            //Stop the timer if all cells are dead
            CountLivingCells();
            if (livingCells == 0 && timer.Enabled == true)
            {
                timer.Enabled = false;
            }
        }

        // Method for counting the neighbors
        // I totally didn't even see the coding tutorial for this, so it looks a lot different than that
        private int CountNeighbors(int xPos, int yPos)
        {
            // The number of living neighbors
            int neighbors = 0;

            // Fit xPos and yPos into discrete array
            if (universe.GetLength(0) < xPos)
            {
                xPos -= universe.GetLength(0);
            }
            else if (xPos < 0)
            {
                xPos += universe.GetLength(0);
            }

            if (universe.GetLength(1) < yPos)
            {
                yPos -= universe.GetLength(1);
            }
            else if (yPos < 0)
            {
                yPos += universe.GetLength(1);
            }

            // Temp x and y (wasn't sure if changing xPos and yPos directly would affect later code)
            int xTemp = xPos;
            int yTemp = yPos;

            // Finite functions
            void xFinite_l(out int x) //left is an edge
            {
                if (xTemp - 1 < 0)
                {
                    xTemp = universe.GetLength(0) + 3;
                }

                x = xTemp;
            }
            void xFinite_r(out int x) //right is an edge
            {
                if (xTemp + 1 >= universe.GetLength(0))
                {
                    xTemp = universe.GetLength(0) + 3;
                }

                x = xTemp;
            }
            void yFinite_t(out int y) //top is an edge
            {
                if (yTemp - 1 < 0)
                {
                    yTemp = universe.GetLength(1) + 3;
                }

                y = yTemp;
            }
            void yFinite_b(out int y) //bottom is an edge
            {
                if (yTemp + 1 >= universe.GetLength(1))
                {
                    yTemp = universe.GetLength(1) + 3;
                }

                y = yTemp;
            }

            // Toroidal functions
            void xToroidal_l(out int x) //left is an edge
            {
                if (xTemp - 1 < 0)
                {
                    xTemp += universe.GetLength(0);
                }

                x = xTemp;
            }
            void xToroidal_r(out int x) //right is an edge
            {
                if (xTemp + 1 >= universe.GetLength(0))
                {
                    xTemp -= universe.GetLength(0);
                }

                x = xTemp;
            }
            void yToroidal_t(out int y) //top is an edge
            {
                if (yTemp - 1 < 0)
                {
                    yTemp += universe.GetLength(1);
                }

                y = yTemp;
            }
            void yToroidal_b(out int y) //bottom is an edge
            {
                if (yTemp + 1 >= universe.GetLength(1))
                {
                    yTemp -= universe.GetLength(1);
                }

                y = yTemp;
            }

            // Methods for checking each surrounding neighbor
            void UpperLeft()
            {
                if (finite)
                {
                    xFinite_l(out xTemp);
                    yFinite_t(out yTemp);
                }
                else
                {
                    xToroidal_l(out xTemp);
                    yToroidal_t(out yTemp);
                }

                if (xTemp - 1 == universe.GetLength(0) + 2 || yTemp - 1 == universe.GetLength(1) + 2)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp - 1, yTemp - 1] == true) //top left corner
                {
                    neighbors++;
                }
            }
            void Left()
            {
                if (finite)
                {
                    xFinite_l(out xTemp);
                }
                else
                {
                    xToroidal_l(out xTemp);
                }

                if (xTemp - 1 == universe.GetLength(0) + 2)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp - 1, yTemp] == true) //directly to left
                {
                    neighbors++;
                }
            }
            void LowerLeft()
            {
                if (finite)
                {
                    xFinite_l(out xTemp);
                    yFinite_b(out yTemp);
                }
                else
                {
                    xToroidal_l(out xTemp);
                    yToroidal_b(out yTemp);
                }

                if (xTemp - 1 == universe.GetLength(0) + 2 || yTemp + 1 == universe.GetLength(1) + 4)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp - 1, yTemp + 1] == true) //bottom left corner
                {
                    neighbors++;
                }
            }
            void Above()
            {
                if (finite)
                {
                    yFinite_t(out yTemp);
                }
                else
                {
                    yToroidal_t(out yTemp);
                }

                if (yTemp - 1 == universe.GetLength(1) + 2)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp, yTemp - 1] == true) //directly above
                {
                    neighbors++;
                }
            }
            void Below()
            {
                if (finite)
                {
                    yFinite_b(out yTemp);
                }
                else
                {
                    yToroidal_b(out yTemp);
                }

                if (yTemp + 1 == universe.GetLength(1) + 4)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp, yTemp + 1] == true) //directly below
                {
                    neighbors++;
                }
            }
            void UpperRight()
            {
                if (finite)
                {
                    xFinite_r(out xTemp);
                    yFinite_t(out yTemp);
                }
                else
                {
                    xToroidal_r(out xTemp);
                    yToroidal_t(out yTemp);
                }

                if (xTemp + 1 == universe.GetLength(0) + 4 || yTemp - 1 == universe.GetLength(1) + 2)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp + 1, yTemp - 1] == true) //upper right corner
                {
                    neighbors++;
                }
            }
            void Right()
            {
                if (finite)
                {
                    xFinite_r(out xTemp);
                }
                else
                {
                    xToroidal_r(out xTemp);
                }

                if (xTemp + 1 == universe.GetLength(0) + 4)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp + 1, yTemp] == true) //directly to right
                {
                    neighbors++;
                }
            }
            void LowerRight()
            {
                if (finite)
                {
                    xFinite_r(out xTemp);
                    yFinite_b(out yTemp);
                }
                else
                {
                    xToroidal_r(out xTemp);
                    yToroidal_b(out yTemp);
                }

                if (xTemp + 1 == universe.GetLength(0) + 4 || yTemp + 1 == universe.GetLength(1) + 4)
                {
                    //do nothing except skip where it checks universe[x, y]
                }
                else if (universe[xTemp + 1, yTemp + 1] == true) //bottom right corner
                {
                    neighbors++;
                }
            }



            // Actually check each neighbor
            xTemp = xPos;
            yTemp = yPos;
            UpperLeft();

            xTemp = xPos;
            yTemp = yPos;
            Left();

            xTemp = xPos;
            yTemp = yPos;
            LowerLeft();

            xTemp = xPos;
            yTemp = yPos;
            Above();

            xTemp = xPos;
            yTemp = yPos;
            Below();

            xTemp = xPos;
            yTemp = yPos;
            UpperRight();

            xTemp = xPos;
            yTemp = yPos;
            Right();

            xTemp = xPos;
            yTemp = yPos;
            LowerRight();
            


            return neighbors;
        }
                
        // Applying the rules to the scratchpad
        private bool[,] ApplyRules()
        {
            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;

            universe = temp;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    neighbors[x, y] = CountNeighbors(x, y);
                }
            }

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // Any living cell with less than 2 living neighbors dies in the next generation
                    if (neighbors[x, y] < 2 && universe[x, y] == true)
                    {
                        scratchPad[x, y] = false;
                    }

                    // Any living cell with more than 3 living neighbors will die in the next generation
                    else if (neighbors[x, y] > 3 && universe[x, y] == true)
                    {
                        scratchPad[x, y] = false;
                    }
                    
                    // Any living cell with 2 or 3 living neighbors lives on in the next generation
                    else if (neighbors[x, y] == 2 && universe[x, y] == true)
                    {
                        scratchPad[x, y] = true;
                    }
                    else if (neighbors[x, y] == 3 && universe[x, y] == true)
                    {
                        scratchPad[x, y] = true;
                    }

                    // Any dead cell with exactly 3 living neighbors will be born in the next generation
                    else if (neighbors[x, y] == 3 && universe[x, y] == false)
                    {
                        scratchPad[x, y] = true;
                    }
                }
            }

            return scratchPad;
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        // Drawing the game
        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Update living cells count on status strip
            CountLivingCells();
            livingCellsToolStripStatusLabel.Text = "Living Cells = " + livingCells.ToString();

            // Update the HUD
            if (hudDisplay)
            {
                hudCellCountStatus.Text = "Cell Count = " + livingCells.ToString() + "  -";
                hudGenerationStatus.Text = "Current Generation = " + generations.ToString() + "  -";
                if (finite)
                {
                    hudCellCountStatus.Text = "Boundary Style = Finite  -";
                }
                else
                {
                    hudCellCountStatus.Text = "Boundary Style = Toroidal  -";
                }
                hudUniverseSizeStatus.Text =
                    "Universe Size: {Height = " + universe.GetLength(1).ToString() +
                    "; Width = " + universe.GetLength(0).ToString() + "}";
            }

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    if (gridDisplay)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }

                    // Draw neighbors in grid
                    if (neighborDisplay)
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        Brush numbers;
                        if (universe[x, y] == true)
                        {
                            numbers = new SolidBrush(livingNumberColor);
                        }
                        else
                        {
                            numbers = new SolidBrush(deadNumberColor);
                        }

                        if (CountNeighbors(x, y) > 0 || universe[x, y] == true)
                        {
                            e.Graphics.DrawString(CountNeighbors(x, y).ToString(), font, numbers, cellRect, stringFormat);
                        }
                    }
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        // Clicking a cell
        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        // Clearing the screen using new file menu option
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            // Set counts back to 0
            generations = 0;
            livingCells = 0;
            
            // Update status strip 
            generationsToolStripStatusLabel.Text = "Generations = " + generations.ToString();
            livingCellsToolStripStatusLabel.Text = "Living Cells = " + livingCells.ToString();

            // Tell Windows you need to repaint
            graphicsPanel1.Invalidate();
        }

        // Changing the background color of the game
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = graphicsPanel1.BackColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                graphicsPanel1.BackColor = dlg.Color;
            }
        }

        // Changing the grid color of the game
        private void gridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = gridColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                gridColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }

        // Changing the color of any boxes that are True
        private void selectedBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = cellColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                cellColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }

        // Start the game using run menu item
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    original[x, y] = universe[x, y];
                }
            }

            timer.Enabled = true;
        }

        // Pause the game using the run menu item
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        // Advance to the next generation
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NextGeneration();
        }

        // Saving the Settings
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.GraphicsPanel1_Backcolor = graphicsPanel1.BackColor;
            Properties.Settings.Default.GraphicsPanel1_Gridcolor = gridColor;
            Properties.Settings.Default.GraphicsPanel1_SelectedBoxColor = cellColor;
            Properties.Settings.Default.GraphicsPanel1_SelectedCellNumberColor = livingNumberColor;
            Properties.Settings.Default.GraphicsPanel1_UnselectedCellNumberColor = deadNumberColor;
            Properties.Settings.Default.Form1_TimerInterval = timer.Interval;
            Properties.Settings.Default.Form1_UniverseRows = universe.GetLength(1);
            Properties.Settings.Default.Form1_UniverseColumns = universe.GetLength(0);

            Properties.Settings.Default.Save();
        }

        // Resetting the Settings
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            graphicsPanel1.BackColor = Properties.Settings.Default.GraphicsPanel1_Backcolor;
            gridColor = Properties.Settings.Default.GraphicsPanel1_Gridcolor;
            cellColor = Properties.Settings.Default.GraphicsPanel1_SelectedBoxColor;
        }

        // Reloading the last saved settings
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();

            graphicsPanel1.BackColor = Properties.Settings.Default.GraphicsPanel1_Backcolor;
            gridColor = Properties.Settings.Default.GraphicsPanel1_Gridcolor;
            cellColor = Properties.Settings.Default.GraphicsPanel1_SelectedBoxColor;
        }

        // Changing the Color to the neighbor numbers within a living cell
        private void selectedBoxNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = livingNumberColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                livingNumberColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }

        // Changing the Color to the neighbor numbers within a dead cell
        private void unselectedBoxNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = deadNumberColor;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                deadNumberColor = dlg.Color;
            }

            graphicsPanel1.Invalidate();
        }

        // Clicking the stop menu item
        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool[,] temp = universe;
            universe = original;
            original = temp;

            timer.Enabled = false;

            graphicsPanel1.Invalidate();
        }

        // Clicking the exit menu item
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clicking the Options item in settings menu
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameOptionsForm GOdlg = new GameOptionsForm();

            GOdlg.Seed = seedInt; 
            GOdlg.Milliseconds = timer.Interval;
            GOdlg.Rows = universe.GetLength(0);
            GOdlg.Columns = universe.GetLength(1);
            if (finite)
            {
                GOdlg.BoundaryStyle = "Finite";
            }
            else
            {
                GOdlg.BoundaryStyle = "Toroidal";
            }

            if (DialogResult.OK == GOdlg.ShowDialog())
            {
                seedInt = GOdlg.Seed;
                timer.Interval = GOdlg.Milliseconds;

                ResizeArray(ref universe, GOdlg.Rows, GOdlg.Columns);
                ResizeArray(ref scratchPad, GOdlg.Rows, GOdlg.Columns);
                ResizeArray(ref neighbors, GOdlg.Rows, GOdlg.Columns);
                ResizeArray(ref original, GOdlg.Rows, GOdlg.Columns);

                if (GOdlg.BoundaryStyle == "Finite")
                {
                    finite = true;
                }
                else
                {
                    finite = false;
                }
            }

            graphicsPanel1.Invalidate();
        }

        // Clicking Randomize in file menu
        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rand = new Random(seedInt);

            for (int x = 0; x < universe.GetLength(0); x++)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    universe[x, y] = false;

                    int randLiving = rand.Next(3);

                    if (randLiving == 0)
                    {
                        universe[x, y] = true;
                    }
                }
            }

            graphicsPanel1.Invalidate();
        }

        // Toggle grid in view
        private void toggleGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridDisplay = !gridDisplay;

            graphicsPanel1.Invalidate();
        }

        // Toggle neighbor count in view
        private void toggleNeighborCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neighborDisplay = !neighborDisplay;

            graphicsPanel1.Invalidate();
        }

        // Toggle HUD in view
        private void toggleHUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hudDisplay = !hudDisplay;

            if (hudDisplay)
            {
                hudStatusStrip.Visible = true;
            }
            else
            {
                hudStatusStrip.Visible = false;
            }

            graphicsPanel1.Invalidate();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFdlg = new SaveFileDialog();
            SFdlg.Filter = "All Files|*.*|Cells|*.cells";
            SFdlg.FilterIndex = 2;
            SFdlg.DefaultExt = "cells";

            if (DialogResult.OK == SFdlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(SFdlg.FileName);

                // Comments of save file
                writer.WriteLine("!Save of GameOfLife game - Class COP-119 - Full Sail University.");
                writer.WriteLine("!Game created by Sierra Clubb, 2020.");

                // Iterate through the universe one row at a time
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    StringBuilder currentRow = new StringBuilder();
                    currentRow.Length = 0;

                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        if (universe[x, y] == true)
                        {
                            currentRow.Append('O');
                        }
                        else if (universe[x, y] == false)
                        {
                            currentRow.Append('.');
                        }
                    }

                    writer.WriteLine(currentRow);
                }

                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Odlg = new OpenFileDialog();
            Odlg.Filter = "All Files|*.*|Cells|*.cells";
            Odlg.FilterIndex = 2;

            if (DialogResult.OK == Odlg.ShowDialog())
            {
                StreamReader reader = new StreamReader(Odlg.FileName);

                // Variables for calculating width and height of file's universe
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size
                while (!reader.EndOfStream)
                {
                    // Read one row at a time
                    string row = reader.ReadLine();

                    if (row[0] != '!') //Ignore the comments
                    {
                        maxHeight++;

                        if (maxWidth < row.Length)
                        {
                            maxWidth = row.Length;
                        }
                    }
                }

                // Resize current arrays in use
                ResizeArray(ref universe, maxHeight, maxWidth);
                ResizeArray(ref scratchPad, maxHeight, maxWidth);
                ResizeArray(ref neighbors, maxHeight, maxWidth);
                ResizeArray(ref original, maxHeight, maxWidth);

                // Move pointer back to beginning of file
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Iterate through the file again, reading in the cells
                int rowNum = -1;
                while (!reader.EndOfStream)
                {
                    // Read one row at a time
                    string row = reader.ReadLine();

                    if (row[0] != '!')
                    {
                        rowNum++;

                        for (int xPos = 0; xPos < row.Length; xPos++)
                        {
                            if (row[xPos] == 'O')
                            {
                                universe[xPos, rowNum] = true;
                            }
                            else if (row[xPos] == '.')
                            {
                                universe[xPos, rowNum] = false;
                            }
                        }
                    }
                }

                reader.Close();
            }

            graphicsPanel1.Invalidate();
        }
    }
}
