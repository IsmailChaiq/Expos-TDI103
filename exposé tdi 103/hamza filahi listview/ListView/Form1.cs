using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //-----------1ere Methode-----------------------------
            //ListViewItem item = new ListViewItem();
            //item.SubItems[0].Text = txtNom.Text;
            //item.SubItems.Add(txtPrenom.Text);
            //item.SubItems.Add(txtAge.Text);
            //lsvStagiaire.Items.Add(item);




            //--------------2eme Methode---------------------------

            //string[] T = new string[] { txtNom.Text, txtPrenom.Text, txtAge.Text };
            //ListViewItem S = new ListViewItem(T);
            //lsvStagiaire.Items.Add(S);



            //-----------3eme Methode--------------------
            ListViewItem K = new ListViewItem(new[] { txtNom.Text, txtPrenom.Text, txtAge.Text });
            lsvStagiaire.Items.Add(K);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //if (lsvStagiaire.SelectedIndices.Count > 0) 
            //{
            //    lsvStagiaire.Items.RemoveAt(lsvStagiaire.SelectedIndices[0]);

            //}


            //--------------- Supprimer Plusieur  ***Multiselect***----------------
            if (lsvStagiaire.SelectedIndices.Count > 0)
            {
                foreach (ListViewItem item in lsvStagiaire.SelectedItems)
                {
                    lsvStagiaire.Items.Remove(item);
                }
            }




        }
    }
}
