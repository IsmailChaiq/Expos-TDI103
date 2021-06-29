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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(afficheF2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            //Form2 f2 = new Form2();
            //f2.Show();

            this.Close();
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(afficheF3);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            this.Close();
        }


        static void afficheF3()
        {
            Application.Run(new Form3());
        }


        static void afficheF2()
        {
            Application.Run(new Form2());
        }
    }
}
