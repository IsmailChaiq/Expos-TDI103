using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exposer_VScrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vsc_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vsc1_Scroll(object sender, ScrollEventArgs e)
        {
            int x;
            x = vsc1.Value;
            lbl1.Text = x.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vscPANEL.Height = grpb1.Height- 20 ;
        }

        private void hsbY_Scroll(object sender, ScrollEventArgs e)
        {
            int y;
            y = hsbY.Value;
            lbl2.Text = y.ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void vscPANEL_Scroll(object sender, ScrollEventArgs e)
        {

            if (e.OldValue < e.NewValue)
            {
                foreach (Control Ctl in grpb1.Controls)
                {
                    if (Ctl is not VScrollBar)
                    {
                        Ctl.Top -= e.NewValue ;
                    }
                }

            }
            else if (e.NewValue < e.OldValue)
            {
                foreach (Control Ctl in grpb1.Controls)
                {
                    if (Ctl is not VScrollBar)
                    {
                        Ctl.Top += e.OldValue ;
                    }
                }
                grpb1.Refresh();
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
