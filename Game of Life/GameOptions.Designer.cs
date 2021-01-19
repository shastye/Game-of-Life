namespace Game_of_Life
{
    partial class GameOptionsForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.millisecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.boundaryStyleLabel = new System.Windows.Forms.Label();
            this.boundaryStyleComboBox = new System.Windows.Forms.ComboBox();
            this.numRowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numColsLabel = new System.Windows.Forms.Label();
            this.numColsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numRowsLabel = new System.Windows.Forms.Label();
            this.universeSizeLabel = new System.Windows.Forms.Label();
            this.universeBehaviorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(422, 293);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(341, 293);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Location = new System.Drawing.Point(59, 76);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(169, 13);
            this.millisecondsLabel.TabIndex = 5;
            this.millisecondsLabel.Text = "Milliseconds Between Generations";
            // 
            // millisecondsUpDown
            // 
            this.millisecondsUpDown.Location = new System.Drawing.Point(236, 72);
            this.millisecondsUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.millisecondsUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.millisecondsUpDown.Name = "millisecondsUpDown";
            this.millisecondsUpDown.Size = new System.Drawing.Size(120, 20);
            this.millisecondsUpDown.TabIndex = 6;
            this.millisecondsUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // boundaryStyleLabel
            // 
            this.boundaryStyleLabel.AutoSize = true;
            this.boundaryStyleLabel.Location = new System.Drawing.Point(149, 110);
            this.boundaryStyleLabel.Name = "boundaryStyleLabel";
            this.boundaryStyleLabel.Size = new System.Drawing.Size(78, 13);
            this.boundaryStyleLabel.TabIndex = 8;
            this.boundaryStyleLabel.Text = "Boundary Style";
            // 
            // boundaryStyleComboBox
            // 
            this.boundaryStyleComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Finite",
            "Toroidal"});
            this.boundaryStyleComboBox.FormattingEnabled = true;
            this.boundaryStyleComboBox.Items.AddRange(new object[] {
            "Finite",
            "Toroidal"});
            this.boundaryStyleComboBox.Location = new System.Drawing.Point(235, 107);
            this.boundaryStyleComboBox.Name = "boundaryStyleComboBox";
            this.boundaryStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.boundaryStyleComboBox.TabIndex = 9;
            this.boundaryStyleComboBox.Text = "Toroidal";
            // 
            // numRowsUpDown
            // 
            this.numRowsUpDown.Location = new System.Drawing.Point(237, 253);
            this.numRowsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRowsUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRowsUpDown.Name = "numRowsUpDown";
            this.numRowsUpDown.Size = new System.Drawing.Size(120, 20);
            this.numRowsUpDown.TabIndex = 10;
            this.numRowsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numColsLabel
            // 
            this.numColsLabel.AutoSize = true;
            this.numColsLabel.Location = new System.Drawing.Point(129, 255);
            this.numColsLabel.Name = "numColsLabel";
            this.numColsLabel.Size = new System.Drawing.Size(99, 13);
            this.numColsLabel.TabIndex = 11;
            this.numColsLabel.Text = "Number of Columns";
            // 
            // numColsUpDown
            // 
            this.numColsUpDown.Location = new System.Drawing.Point(237, 219);
            this.numColsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numColsUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numColsUpDown.Name = "numColsUpDown";
            this.numColsUpDown.Size = new System.Drawing.Size(120, 20);
            this.numColsUpDown.TabIndex = 12;
            this.numColsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numRowsLabel
            // 
            this.numRowsLabel.AutoSize = true;
            this.numRowsLabel.Location = new System.Drawing.Point(142, 221);
            this.numRowsLabel.Name = "numRowsLabel";
            this.numRowsLabel.Size = new System.Drawing.Size(86, 13);
            this.numRowsLabel.TabIndex = 13;
            this.numRowsLabel.Text = "Number of Rows";
            // 
            // universeSizeLabel
            // 
            this.universeSizeLabel.AutoSize = true;
            this.universeSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.universeSizeLabel.Location = new System.Drawing.Point(67, 182);
            this.universeSizeLabel.Name = "universeSizeLabel";
            this.universeSizeLabel.Size = new System.Drawing.Size(161, 24);
            this.universeSizeLabel.TabIndex = 14;
            this.universeSizeLabel.Text = "Size of Universe";
            // 
            // universeBehaviorLabel
            // 
            this.universeBehaviorLabel.AutoSize = true;
            this.universeBehaviorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.universeBehaviorLabel.Location = new System.Drawing.Point(25, 34);
            this.universeBehaviorLabel.Name = "universeBehaviorLabel";
            this.universeBehaviorLabel.Size = new System.Drawing.Size(203, 24);
            this.universeBehaviorLabel.TabIndex = 15;
            this.universeBehaviorLabel.Text = "Behavior of Universe";
            // 
            // GameOptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 327);
            this.Controls.Add(this.universeBehaviorLabel);
            this.Controls.Add(this.universeSizeLabel);
            this.Controls.Add(this.numRowsLabel);
            this.Controls.Add(this.numColsUpDown);
            this.Controls.Add(this.numColsLabel);
            this.Controls.Add(this.numRowsUpDown);
            this.Controls.Add(this.boundaryStyleComboBox);
            this.Controls.Add(this.boundaryStyleLabel);
            this.Controls.Add(this.millisecondsUpDown);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "GameOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Options";
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label millisecondsLabel;
        private System.Windows.Forms.NumericUpDown millisecondsUpDown;
        private System.Windows.Forms.Label boundaryStyleLabel;
        private System.Windows.Forms.ComboBox boundaryStyleComboBox;
        private System.Windows.Forms.NumericUpDown numRowsUpDown;
        private System.Windows.Forms.Label numColsLabel;
        private System.Windows.Forms.NumericUpDown numColsUpDown;
        private System.Windows.Forms.Label numRowsLabel;
        private System.Windows.Forms.Label universeSizeLabel;
        private System.Windows.Forms.Label universeBehaviorLabel;
    }
}