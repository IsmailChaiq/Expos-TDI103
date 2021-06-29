using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EXPOSEETIMER
{
    public partial class Form1 : Form
    {
        int V = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtValue.Text = (V++).ToString();    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 1000;
            //if (int.TryParse(txtValue.Text, out V))
            //{
            //timer1.Start();
            //}
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
                timer1.Stop();
        }

        private void btnPointDepart_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
    }
}
