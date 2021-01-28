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
    public partial class PropertiesForm : Form
    {
        public PropertiesForm(Form1 t_form1, RandomizeOptionsForm t_rand, GameOptionsForm t_options)
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = t_rand.SeedControl;
        }
    }
}
