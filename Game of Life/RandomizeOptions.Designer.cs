namespace Game_of_Life
{
    partial class RandomizeOptionsForm
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
            this.randSeedButton = new System.Windows.Forms.Button();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.seedLabel = new System.Windows.Forms.Label();
            this.randGroupBox = new System.Windows.Forms.GroupBox();
            this.knownSeedRadioButton = new System.Windows.Forms.RadioButton();
            this.timeSeedRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            this.randGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(422, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(341, 291);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // randSeedButton
            // 
            this.randSeedButton.Location = new System.Drawing.Point(300, 222);
            this.randSeedButton.Name = "randSeedButton";
            this.randSeedButton.Size = new System.Drawing.Size(75, 23);
            this.randSeedButton.TabIndex = 7;
            this.randSeedButton.Text = "Randomize";
            this.randSeedButton.UseVisualStyleBackColor = true;
            this.randSeedButton.Click += new System.EventHandler(this.randSeedButton_Click);
            // 
            // seedUpDown
            // 
            this.seedUpDown.Location = new System.Drawing.Point(174, 223);
            this.seedUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.seedUpDown.Name = "seedUpDown";
            this.seedUpDown.Size = new System.Drawing.Size(120, 20);
            this.seedUpDown.TabIndex = 6;
            this.seedUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(134, 227);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 5;
            this.seedLabel.Text = "Seed";
            // 
            // randGroupBox
            // 
            this.randGroupBox.Controls.Add(this.timeSeedRadioButton);
            this.randGroupBox.Controls.Add(this.knownSeedRadioButton);
            this.randGroupBox.Location = new System.Drawing.Point(154, 33);
            this.randGroupBox.Name = "randGroupBox";
            this.randGroupBox.Size = new System.Drawing.Size(200, 144);
            this.randGroupBox.TabIndex = 8;
            this.randGroupBox.TabStop = false;
            this.randGroupBox.Text = "Randomization Style";
            // 
            // knownSeedRadioButton
            // 
            this.knownSeedRadioButton.AutoSize = true;
            this.knownSeedRadioButton.Location = new System.Drawing.Point(55, 43);
            this.knownSeedRadioButton.Name = "knownSeedRadioButton";
            this.knownSeedRadioButton.Size = new System.Drawing.Size(86, 17);
            this.knownSeedRadioButton.TabIndex = 0;
            this.knownSeedRadioButton.Text = "Known Seed";
            this.knownSeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // timeSeedRadioButton
            // 
            this.timeSeedRadioButton.AutoSize = true;
            this.timeSeedRadioButton.Location = new System.Drawing.Point(55, 86);
            this.timeSeedRadioButton.Name = "timeSeedRadioButton";
            this.timeSeedRadioButton.Size = new System.Drawing.Size(109, 17);
            this.timeSeedRadioButton.TabIndex = 1;
            this.timeSeedRadioButton.Text = "Time Based Seed";
            this.timeSeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomizeOptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(509, 327);
            this.ControlBox = false;
            this.Controls.Add(this.randGroupBox);
            this.Controls.Add(this.randSeedButton);
            this.Controls.Add(this.seedUpDown);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RandomizeOptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Randomize Options";
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            this.randGroupBox.ResumeLayout(false);
            this.randGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button randSeedButton;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.GroupBox randGroupBox;
        private System.Windows.Forms.RadioButton timeSeedRadioButton;
        private System.Windows.Forms.RadioButton knownSeedRadioButton;
    }
}