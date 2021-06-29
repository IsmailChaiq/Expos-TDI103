using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ucColor1_ColourChange(object sender, EventArgs e)
        {
            txtblue.Text = ucColor1.ControlColor.B.ToString();
            txtRouge.Text = ucColor1.ControlColor.R.ToString();
            txtVert.Text = ucColor1.ControlColor.G.ToString();
            
        }

    }
}
