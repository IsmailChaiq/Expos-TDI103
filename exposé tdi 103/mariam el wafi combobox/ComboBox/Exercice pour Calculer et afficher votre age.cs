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
    public partial class Exercice_pour_Calculer_et_afficher_votre_age : Form
    {
        public Exercice_pour_Calculer_et_afficher_votre_age()
        {
            InitializeComponent();
        }

        private void Exercice_pour_Calculer_et_afficher_votre_age_Load(object sender, EventArgs e)
        {
            string[] liste_mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "septembre", "Octobre", "Novembre", "Décembre" };
            comboMois.Items.AddRange(liste_mois);
            
            for (int i = 1; i < 31; i++)
            {
                comboJours.Items.Add(i.ToString());
            }
            for (int j = 1990; j < 2021; j++)
            {
                ComboAnnée.Items.Add(j.ToString());
            }


        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre Date De Naissance :" + comboJours.Text+"/" + comboMois.Text + "/" + ComboAnnée.Text);
        }

        private void Calculer_Click(object sender, EventArgs e)
        {
            int c;
            int age;
            c = DateTime.Today.Year;//2021
            age = c - Convert.ToInt32( ComboAnnée.Text);//la date selectionnée
            MessageBox.Show("Votre Age :" +"\t"+ age);

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
