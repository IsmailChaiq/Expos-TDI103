using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace threadWin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(afficheF1);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(afficheF2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close();
        }

        public static void afficheF1()
        {
            Application.Run(new Form1());
        }

        public static void afficheF2()
        {
            Application.Run(new Form2());
        }
    }


}
