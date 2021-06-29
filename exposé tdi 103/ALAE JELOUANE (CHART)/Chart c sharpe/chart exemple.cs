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
        int SF;
        int SM;
        int SNF;
        int SNM;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            chartSalary.Series["Female"].Points.Clear();
            chartSalary.Series["Male"].Points.Clear();

            for (int i = 0; i < LS.Count; i++)
            {
               
                chartSalary.Series["Female"].Points.AddXY("Female", SF/SNF) ;
                chartSalary.Series["Male"].Points.AddXY("Male", SM/SNM);
            }
            
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Personne P = new Personne();
            P.Nom = txtNom.Text;
            P.age = int.Parse(txtAge.Text);

            if (checkF.Checked==true)
            {
                P.sex = 'F';
                SF = int.Parse(txtAge.Text);
                SNF = SNF+ 1;
            }
            if (checkM.Checked == true)
            {
                P.sex = 'M';
                SM = int.Parse(txtAge.Text);
                SNM = SNM+ 1;
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
