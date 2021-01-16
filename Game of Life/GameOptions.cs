using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class GameOptionsForm : Form
    {
        public GameOptionsForm()
        {
            InitializeComponent();
        }

        // Allows access to seed value in Form1
        public int Seed
        {
            get
            {
                return (int)seedUpDown.Value;
            }
            set
            {
                seedUpDown.Value = (decimal)value;
            }
        }

        // Allows access to timer value in Form1
        public int Milliseconds
        {
            get
            {
                return (int)millisecondsUpDown.Value;
            }
            set
            {
                millisecondsUpDown.Value = (decimal)value;
            }
        }

        // Allows access to boundary style
        public string BoundaryStyle
        {
            get
            {
                return boundaryStyleComboBox.SelectedItem.ToString();
            }
            set
            {
                boundaryStyleComboBox.SelectedItem = (object)value;
            }
        }

        //Allows access to number of rows
        public int Rows
        {
            get
            {
                return (int)numRowsUpDown.Value;
            }
            set
            {
                numRowsUpDown.Value = (decimal)value;
            }
        }

        //Allows access to number of cols
        public int Columns
        {
            get
            {
                return (int)numColsUpDown.Value;
            }
            set
            {
                numColsUpDown.Value = (decimal)value;
            }
        }

        // Clicking randomize next to seed
        private void randSeedButton_Click(object sender, EventArgs e)
        {
            Random randSeed = new Random();
            this.Seed = randSeed.Next((int)seedUpDown.Maximum);
        }
    }
}
