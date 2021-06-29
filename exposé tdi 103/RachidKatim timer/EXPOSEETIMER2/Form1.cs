using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXPOSEETIMER2
{
    public partial class Form1 : Form
    {
        int MSeconds; int Seconds; int Minutes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PointDepartTime();
        }

        private void PointDepartTime()
        {
            txtMseconds.Text = "00";
            txtSecond.Text = "00";
            txtMinutes.Text = "00";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnPointDepart_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MSeconds = 0; Seconds = 0; Minutes = 0;
            PointDepartTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtMseconds.Text = (MSeconds++).ToString();
            if (MSeconds >= 10)
            {
                MSeconds = 0;
                txtSecond.Text = (Seconds++).ToString();
                //if (Seconds >= 12)
                //{
                //    PointDepartTime();
                //    timer1.Stop();
                //    MessageBox.Show("stop");
                //}

                if (Seconds >= 60)
                {
                    Seconds = 0;
                    txtMinutes.Text = (Minutes++).ToString();

                    if (Minutes >= 5)
                    {
                        PointDepartTime();
                        timer1.Stop();
                        //MessageBox.Show("Le temps s'est ècoulé ");
                    }
                }

            }
        }
    }
}
