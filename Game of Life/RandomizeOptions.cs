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
    public partial class RandomizeOptionsForm : Form
    {
        public RandomizeOptionsForm()
        {
            InitializeComponent();

            knownSeedRadioButton.Checked = true;
        }

        // Allows access to seed value in Form1
        public int Seed
        {
            get
            {
                return (int)Math.Abs(seedUpDown.Value);
            }
            set
            {
                seedUpDown.Value = (decimal)Math.Abs(value);
            }
        }

        // Allows access to seed value maximum
        public int SeedMax
        {
            get
            {
                return (int)seedUpDown.Maximum;
            }
            private set
            {
                seedUpDown.Maximum = value;
            }
        }

        // Access to certain containers for property form
        public Control SeedControl
        {
            get
            {
                return seedUpDown;
            }
        }

        public string RandStyle
        {
            get
            {
                if (knownSeedRadioButton.Checked == true)
                {
                    return "known";
                }
                else
                {
                    return "time";
                }
            }
            set
            {
                if (value == "known")
                {
                    knownSeedRadioButton.Checked = true;
                }
                else
                {
                    timeSeedRadioButton.Checked = true;
                }
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
