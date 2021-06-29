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
    public partial class Remplissage_d_une_combobox_a_d_autre_combobox : Form
    {
        public Remplissage_d_une_combobox_a_d_autre_combobox()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") 
            { 
            string ville = textBox1.Text;
             comboBox1.Items.Add(ville);           
            textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Champ ville obligatior");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombre = comboBox1.Items.Count;
            MessageBox.Show("Le nombre des villes est : " + nombre);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            MessageBox.Show("La ville qui Vous avez choisie est réorganisée : " + indice );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("L'élement tu es selectionée c'est  : " + comboBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;

            comboBox1.Items.RemoveAt(indice);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
