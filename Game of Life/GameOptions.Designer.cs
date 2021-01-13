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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.seedLabel = new System.Windows.Forms.Label();
            this.seedUpDown = new System.Windows.Forms.NumericUpDown();
            this.randSeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(289, 237);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(208, 237);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "Okay";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(90, 45);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 2;
            this.seedLabel.Text = "Seed";
            // 
            // seedUpDown
            // 
            this.seedUpDown.Location = new System.Drawing.Point(128, 41);
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
            this.randSeedButton.Location = new System.Drawing.Point(254, 40);
            this.randSeedButton.Name = "randSeedButton";
            this.randSeedButton.Size = new System.Drawing.Size(75, 23);
            this.randSeedButton.TabIndex = 4;
            this.randSeedButton.Text = "Randomize";
            this.randSeedButton.UseVisualStyleBackColor = true;
            this.randSeedButton.Click += new System.EventHandler(this.randSeedButton_Click);
            // 
            // GameOptionsForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 272);
            this.Controls.Add(this.randSeedButton);
            this.Controls.Add(this.seedUpDown);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "GameOptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Options";
            ((System.ComponentModel.ISupportInitialize)(this.seedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.NumericUpDown seedUpDown;
        private System.Windows.Forms.Button randSeedButton;
    }
}