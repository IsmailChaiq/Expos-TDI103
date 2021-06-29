using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_c_sharpe
{
    public partial class Form1 : Form
    {

        
        public List<Personne> LS = new List<Personne>();

        Personne P = new Personne();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            float SF;
            float SM;
            int SNF;
            int SNM;
            SF = 0;
            SM = 0;
            SNF = 0;
            SNM = 0;
            chartSalary.Series["Female"].Points.Clear();
            chartSalary.Series["Male"].Points.Clear();
            for (int i = 0; i < LS.Count; i++)
            {
                if (P.sex=='F')
                {
                    SF += float.Parse(txtAge.Text);
                    SNF += 1;
                }
                else
                {
                    SM += float.Parse(txtAge.Text);
                    SNM += 1;
                }
            }

            for (int i = 0; i < LS.Count; i++)
            {
               
                chartSalary.Series["Female"].Points.AddXY("Female", SF/SNF) ;
                chartSalary.Series["Male"].Points.AddXY("Male", SM/SNM);
            }
            
        }

        ///---------------------------------------------------------------------------------
        ///---------------------------------------------------------------------------------
        


        private void btnAjouter_Click(object sender, EventArgs e)
        {

            P.Nom = txtNom.Text;
            P.age = int.Parse(txtAge.Text);
            if (checkF.Checked==true)
            {
                P.sex = 'F';
            }
            if (checkM.Checked == true)
            {
                P.sex = 'M';
            }
            LS.Add(P);

            dgvPersonne.DataSource = null;
            dgvPersonne.DataSource = LS;

            txtNom.Text = null;
            txtAge.Text = null;

        }

        private void chartSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
