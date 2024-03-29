﻿namespace Game_of_Life
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.randomizeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleHUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridX10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoxNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectedBoxNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.generationsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.livingCellsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.seedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.intervalToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.startContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.colorContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedBoxNumbersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unselectedBoxNumbersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudStatusStrip = new System.Windows.Forms.StatusStrip();
            this.hudGenerationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.hudCellCountStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.hudBoundaryStyleStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.hudUniverseSizeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelContextMenuStrip.SuspendLayout();
            this.hudStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.randomizeOptionsToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(216, 6);
            // 
            // randomizeOptionsToolStripMenuItem
            // 
            this.randomizeOptionsToolStripMenuItem.Name = "randomizeOptionsToolStripMenuItem";
            this.randomizeOptionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.randomizeOptionsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.randomizeOptionsToolStripMenuItem.Text = "Randomize Options";
            this.randomizeOptionsToolStripMenuItem.Click += new System.EventHandler(this.randomizeOptionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(216, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.StartIcon;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.startToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.NextIcon;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.PauseIcon;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::Game_of_Life.Properties.Resources.StopIcon;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleGridToolStripMenuItem,
            this.toggleNeighborCountToolStripMenuItem,
            this.toggleHUDToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // toggleGridToolStripMenuItem
            // 
            this.toggleGridToolStripMenuItem.Name = "toggleGridToolStripMenuItem";
            this.toggleGridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.toggleGridToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.toggleGridToolStripMenuItem.Text = "Grid";
            this.toggleGridToolStripMenuItem.Click += new System.EventHandler(this.toggleGridToolStripMenuItem_Click);
            // 
            // toggleNeighborCountToolStripMenuItem
            // 
            this.toggleNeighborCountToolStripMenuItem.Name = "toggleNeighborCountToolStripMenuItem";
            this.toggleNeighborCountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.toggleNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.toggleNeighborCountToolStripMenuItem.Text = "Neighbor Count";
            this.toggleNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.toggleNeighborCountToolStripMenuItem_Click);
            // 
            // toggleHUDToolStripMenuItem
            // 
            this.toggleHUDToolStripMenuItem.Name = "toggleHUDToolStripMenuItem";
            this.toggleHUDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.toggleHUDToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.toggleHUDToolStripMenuItem.Text = "HUD";
            this.toggleHUDToolStripMenuItem.Click += new System.EventHandler(this.toggleHUDToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.toolStripSeparator3,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator4,
            this.reloadToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem1,
            this.gridToolStripMenuItem1,
            this.gridX10ToolStripMenuItem,
            this.selectedBoxToolStripMenuItem1,
            this.selectedBoxNumbersToolStripMenuItem,
            this.unselectedBoxNumbersToolStripMenuItem});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.colorToolStripMenuItem1.Text = "&Color";
            // 
            // backgroundToolStripMenuItem1
            // 
            this.backgroundToolStripMenuItem1.Name = "backgroundToolStripMenuItem1";
            this.backgroundToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.backgroundToolStripMenuItem1.Text = "Background";
            this.backgroundToolStripMenuItem1.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem1
            // 
            this.gridToolStripMenuItem1.Name = "gridToolStripMenuItem1";
            this.gridToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.gridToolStripMenuItem1.Text = "Grid";
            this.gridToolStripMenuItem1.Click += new System.EventHandler(this.gridToolStripMenuItem1_Click);
            // 
            // gridX10ToolStripMenuItem
            // 
            this.gridX10ToolStripMenuItem.Name = "gridX10ToolStripMenuItem";
            this.gridX10ToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gridX10ToolStripMenuItem.Text = "Grid x10";
            this.gridX10ToolStripMenuItem.Click += new System.EventHandler(this.gridX10ToolStripMenuItem_Click);
            // 
            // selectedBoxToolStripMenuItem1
            // 
            this.selectedBoxToolStripMenuItem1.Name = "selectedBoxToolStripMenuItem1";
            this.selectedBoxToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.selectedBoxToolStripMenuItem1.Text = "Selected Box";
            this.selectedBoxToolStripMenuItem1.Click += new System.EventHandler(this.selectedBoxToolStripMenuItem_Click);
            // 
            // selectedBoxNumbersToolStripMenuItem
            // 
            this.selectedBoxNumbersToolStripMenuItem.Name = "selectedBoxNumbersToolStripMenuItem";
            this.selectedBoxNumbersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.selectedBoxNumbersToolStripMenuItem.Text = "Selected Box Numbers";
            this.selectedBoxNumbersToolStripMenuItem.Click += new System.EventHandler(this.selectedBoxNumbersToolStripMenuItem_Click);
            // 
            // unselectedBoxNumbersToolStripMenuItem
            // 
            this.unselectedBoxNumbersToolStripMenuItem.Name = "unselectedBoxNumbersToolStripMenuItem";
            this.unselectedBoxNumbersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.unselectedBoxNumbersToolStripMenuItem.Text = "Unselected Box Numbers";
            this.unselectedBoxNumbersToolStripMenuItem.Click += new System.EventHandler(this.unselectedBoxNumbersToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(179, 6);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.startToolStripButton,
            this.stopToolStripButton,
            this.pauseToolStripButton,
            this.toolStripSeparator2,
            this.nextToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New (Ctrl + N)";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open (Ctrl + O)";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save (Ctrl + S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = global::Game_of_Life.Properties.Resources.StartIcon;
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.startToolStripButton.Text = "Start (F1)";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopToolStripButton.Image = global::Game_of_Life.Properties.Resources.StopIcon;
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.stopToolStripButton.Text = "Stop (F4)";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseToolStripButton.Image = global::Game_of_Life.Properties.Resources.PauseIcon;
            this.pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pauseToolStripButton.Text = "Pause (F3)";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = global::Game_of_Life.Properties.Resources.NextIcon;
            this.nextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.nextToolStripButton.Text = "Next (F2)";
            this.nextToolStripButton.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generationsToolStripStatusLabel,
            this.livingCellsToolStripStatusLabel,
            this.seedToolStripStatusLabel,
            this.intervalToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 672);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(601, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // generationsToolStripStatusLabel
            // 
            this.generationsToolStripStatusLabel.Name = "generationsToolStripStatusLabel";
            this.generationsToolStripStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.generationsToolStripStatusLabel.Text = "Generations = 0";
            // 
            // livingCellsToolStripStatusLabel
            // 
            this.livingCellsToolStripStatusLabel.Name = "livingCellsToolStripStatusLabel";
            this.livingCellsToolStripStatusLabel.Size = new System.Drawing.Size(87, 17);
            this.livingCellsToolStripStatusLabel.Text = "Living Cells = 0";
            // 
            // seedToolStripStatusLabel
            // 
            this.seedToolStripStatusLabel.Name = "seedToolStripStatusLabel";
            this.seedToolStripStatusLabel.Size = new System.Drawing.Size(70, 17);
            this.seedToolStripStatusLabel.Text = "Seed = 2019";
            // 
            // intervalToolStripStatusLabel
            // 
            this.intervalToolStripStatusLabel.Name = "intervalToolStripStatusLabel";
            this.intervalToolStripStatusLabel.Size = new System.Drawing.Size(72, 17);
            this.intervalToolStripStatusLabel.Text = "Interval = 20";
            // 
            // panelContextMenuStrip
            // 
            this.panelContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContextMenuItem,
            this.toolStripSeparator8,
            this.startContextMenuItem,
            this.pauseContextMenuItem,
            this.nextContextMenuItem,
            this.toolStripSeparator9,
            this.colorContextMenuItem,
            this.toolStripSeparator7,
            this.optionsContextMenuItem});
            this.panelContextMenuStrip.Name = "panelContextMenuStrip";
            this.panelContextMenuStrip.Size = new System.Drawing.Size(117, 154);
            // 
            // newContextMenuItem
            // 
            this.newContextMenuItem.Name = "newContextMenuItem";
            this.newContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newContextMenuItem.Text = "&New";
            this.newContextMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(113, 6);
            // 
            // startContextMenuItem
            // 
            this.startContextMenuItem.Name = "startContextMenuItem";
            this.startContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.startContextMenuItem.Text = "Start";
            this.startContextMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseContextMenuItem
            // 
            this.pauseContextMenuItem.Name = "pauseContextMenuItem";
            this.pauseContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseContextMenuItem.Text = "Pause";
            this.pauseContextMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextContextMenuItem
            // 
            this.nextContextMenuItem.Name = "nextContextMenuItem";
            this.nextContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.nextContextMenuItem.Text = "Next";
            this.nextContextMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(113, 6);
            // 
            // colorContextMenuItem
            // 
            this.colorContextMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.selectedBoxToolStripMenuItem,
            this.selectedBoxNumbersToolStripMenuItem1,
            this.unselectedBoxNumbersToolStripMenuItem1});
            this.colorContextMenuItem.Name = "colorContextMenuItem";
            this.colorContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.colorContextMenuItem.Text = "&Color";
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.backgroundToolStripMenuItem.Text = "Background";
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem1_Click);
            // 
            // selectedBoxToolStripMenuItem
            // 
            this.selectedBoxToolStripMenuItem.Name = "selectedBoxToolStripMenuItem";
            this.selectedBoxToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.selectedBoxToolStripMenuItem.Text = "Selected Box";
            this.selectedBoxToolStripMenuItem.Click += new System.EventHandler(this.selectedBoxToolStripMenuItem_Click);
            // 
            // selectedBoxNumbersToolStripMenuItem1
            // 
            this.selectedBoxNumbersToolStripMenuItem1.Name = "selectedBoxNumbersToolStripMenuItem1";
            this.selectedBoxNumbersToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.selectedBoxNumbersToolStripMenuItem1.Text = "Selected Box Numbers";
            // 
            // unselectedBoxNumbersToolStripMenuItem1
            // 
            this.unselectedBoxNumbersToolStripMenuItem1.Name = "unselectedBoxNumbersToolStripMenuItem1";
            this.unselectedBoxNumbersToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.unselectedBoxNumbersToolStripMenuItem1.Text = "Unselected Box Numbers";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(113, 6);
            // 
            // optionsContextMenuItem
            // 
            this.optionsContextMenuItem.Name = "optionsContextMenuItem";
            this.optionsContextMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsContextMenuItem.Text = "&Options";
            this.optionsContextMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // hudStatusStrip
            // 
            this.hudStatusStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.hudStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hudGenerationStatus,
            this.hudCellCountStatus,
            this.hudBoundaryStyleStatus,
            this.hudUniverseSizeStatus});
            this.hudStatusStrip.Location = new System.Drawing.Point(0, 49);
            this.hudStatusStrip.Name = "hudStatusStrip";
            this.hudStatusStrip.Size = new System.Drawing.Size(601, 22);
            this.hudStatusStrip.SizingGrip = false;
            this.hudStatusStrip.TabIndex = 2;
            this.hudStatusStrip.Text = "hudStatusStrip";
            this.panelToolTip.SetToolTip(this.hudStatusStrip, "HUD: can remove from screen under the view menu");
            // 
            // hudGenerationStatus
            // 
            this.hudGenerationStatus.Name = "hudGenerationStatus";
            this.hudGenerationStatus.Size = new System.Drawing.Size(139, 17);
            this.hudGenerationStatus.Text = "Current Generation = 0  -";
            // 
            // hudCellCountStatus
            // 
            this.hudCellCountStatus.Name = "hudCellCountStatus";
            this.hudCellCountStatus.Size = new System.Drawing.Size(94, 17);
            this.hudCellCountStatus.Text = "Cell Count = 0  -";
            // 
            // hudBoundaryStyleStatus
            // 
            this.hudBoundaryStyleStatus.Name = "hudBoundaryStyleStatus";
            this.hudBoundaryStyleStatus.Size = new System.Drawing.Size(153, 17);
            this.hudBoundaryStyleStatus.Text = "Boundary Style = Toroidal  -";
            // 
            // hudUniverseSizeStatus
            // 
            this.hudUniverseSizeStatus.Name = "hudUniverseSizeStatus";
            this.hudUniverseSizeStatus.Size = new System.Drawing.Size(211, 17);
            this.hudUniverseSizeStatus.Text = "Universe Size = {Height = 5; Width = 5}";
            // 
            // panelToolTip
            // 
            this.panelToolTip.ToolTipTitle = "Directions";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.panelContextMenuStrip;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 71);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(601, 601);
            this.graphicsPanel1.TabIndex = 3;
            this.panelToolTip.SetToolTip(this.graphicsPanel1, "Click on a cell to toggle whether it is living or dead.");
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 694);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.hudStatusStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelContextMenuStrip.ResumeLayout(false);
            this.hudStatusStrip.ResumeLayout(false);
            this.hudStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip panelContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem colorContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectedBoxNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unselectedBoxNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedBoxNumbersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unselectedBoxNumbersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem randomizeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel livingCellsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel generationsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleHUDToolStripMenuItem;
        private System.Windows.Forms.StatusStrip hudStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel hudGenerationStatus;
        private System.Windows.Forms.ToolStripStatusLabel hudCellCountStatus;
        private System.Windows.Forms.ToolStripStatusLabel hudBoundaryStyleStatus;
        private System.Windows.Forms.ToolStripStatusLabel hudUniverseSizeStatus;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem newContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem startContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextContextMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem optionsContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel seedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel intervalToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem toggleGridToolStripMenuItem;
        private System.Windows.Forms.ToolTip panelToolTip;
        private System.Windows.Forms.ToolStripMenuItem gridX10ToolStripMenuItem;
    }
}

