using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class FrmListepays__2 : Form
    {
        public FrmListepays__2()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }      
        private void cmbpysa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmListepays_Load(object sender, EventArgs e)
        {
            cmbpayseE.Text = "Choisir Votre Pays De Naissance";
            liste.Items.Add("Nom et lieu de naisance : \n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            liste.Items.Add("=>"+txtprenom.Text+" " + txtnom.Text +" a augmenté au "+";"+ cmbpayseE.Text);

        }

        private void cmbpayseE_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
