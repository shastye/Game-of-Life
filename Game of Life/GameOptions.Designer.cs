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
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.randSeedButton = new System.Windows.Forms.Button();
            this.millisecondsLabel = new System.Windows.Forms.Label();
            this.millisecondsUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(422, 237);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(341, 237);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Okay";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(198, 40);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 2;
            this.seedLabel.Text = "Seed";
            // 
            // seedUpDown
            // 
            this.seedUpDown.Location = new System.Drawing.Point(238, 36);
            this.seedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.seedUpDown.Name = "seedUpDown";
            this.seedUpDown.Size = new System.Drawing.Size(120, 20);
            this.seedUpDown.TabIndex = 3;
            this.seedUpDown.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // randSeedButton
            // 
            this.randSeedButton.Location = new System.Drawing.Point(364, 35);
            this.randSeedButton.Name = "randSeedButton";
            this.randSeedButton.Size = new System.Drawing.Size(75, 23);
            this.randSeedButton.TabIndex = 4;
            this.randSeedButton.Text = "Randomize";
            this.randSeedButton.UseVisualStyleBackColor = true;
            this.randSeedButton.Click += new System.EventHandler(this.randSeedButton_Click);
            // 
            // millisecondsLabel
            // 
            this.millisecondsLabel.AutoSize = true;
            this.millisecondsLabel.Location = new System.Drawing.Point(61, 91);
            this.millisecondsLabel.Name = "millisecondsLabel";
            this.millisecondsLabel.Size = new System.Drawing.Size(169, 13);
            this.millisecondsLabel.TabIndex = 5;
            this.millisecondsLabel.Text = "Milliseconds Between Generations";
            // 
            // millisecondsUpDown
            // 
            this.millisecondsUpDown.Location = new System.Drawing.Point(238, 87);
            this.millisecondsUpDown.Name = "millisecondsUpDown";
            this.millisecondsUpDown.Size = new System.Drawing.Size(120, 20);
            this.millisecondsUpDown.TabIndex = 6;
            // 
            // GameOptionsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 272);
            this.Controls.Add(this.millisecondsUpDown);
            this.Controls.Add(this.millisecondsLabel);
            this.Controls.Add(this.randSeedButton);
            this.Controls.Add(this.seedUpDown);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "GameOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Options";
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millisecondsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Button randSeedButton;
        private System.Windows.Forms.Label millisecondsLabel;
        private System.Windows.Forms.NumericUpDown millisecondsUpDown;
    }
}