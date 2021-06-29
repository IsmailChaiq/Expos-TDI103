using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string PictureFileName;
        public string _PictureFileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            //setupDgv();
            ((DataGridViewComboBoxColumn)dgvEmployes.Columns["etat"]).Items.Add("Livré");
            ((DataGridViewComboBoxColumn)dgvEmployes.Columns["etat"]).Items.Add("En attente");
            ((DataGridViewComboBoxColumn)dgvEmployes.Columns["etat"]).Items.Add("Retard");

        }
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            // Affiche une fenetre pour selectionner l'image
            openFileDialog1.ShowDialog();
            PictureFileName = openFileDialog1.FileName;
            pctBoxPicture.Image = Image.FromFile(PictureFileName);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            clsProduit produit = new clsProduit(txtNom.Text,  PictureFileName, cmbEtat.Text[0], chkBoxFragile.Checked, int.Parse(nudQte.Value.ToString()), dateTimePicker1.Value);
            clsProduit.ListeProduits.Add(produit);
            reloadDgv();
        }
        
        public void setupDgv()
        {
            // Desactive la visibilité des columns ajouté automatiquement lors l'utilisation du DataSource
            dgvEmployes.Columns["Fragile"].Visible = false;
            dgvEmployes.Columns["Etat"].Visible = false;


        }

        public void reloadDgv()
        {
            dgvEmployes.Rows.Clear();

            for (int i = 0; i < clsProduit.ListeProduits.Count; i++)
            {
                clsProduit produit = clsProduit.ListeProduits[i];
                //DataGridViewRow row = new DataGridViewRow();
                dgvEmployes.Rows.Add();
                dgvEmployes.Rows[i].Cells["image"].Value = Image.FromFile(produit.PictureFilename);
                dgvEmployes.Rows[i].Cells["nom"].Value = produit.Nom;
                dgvEmployes.Rows[i].Cells["fragile"].Value = produit.Fragile;
                dgvEmployes.Rows[i].Cells["id"].Value = produit.Id;
                switch (produit.Etat)
                {
                    case 'L':
                        dgvEmployes.Rows[i].Cells["etat"].Value = "Livré";
                        break;
                    case 'E':
                        dgvEmployes.Rows[i].Cells["etat"].Value = "En attente";
                        break;
                    case 'R':
                        dgvEmployes.Rows[i].Cells["etat"].Value = "Retard";
                        break;
                }
            }

            // Modifie l'ordre d'affichage des deux columns
            dgvEmployes.Columns["Nom"].DisplayIndex = 1;
            //dgvEmployes.Columns["id"].DisplayIndex = 0;
            dgvEmployes.Columns["id"].Visible = false;


        }

        /* L'objet DataGridViewButtonColumn n'a pas d'evenement gérer lors du click
           On gère l'evenement lors du click sur n'importe quelle case du dgvEmployes */


        private void dgvEmployes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /* L'objet e contient les arguments de l'evenement click 
               On compare l'indice de la colonne clické avec l'indice de la colonne du boutton */

            if (e.ColumnIndex == dgvEmployes.Columns["Supp"].Index)
            {
                clsProduit.supprimerID(int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString()));
                reloadDgv();
            }
            if (e.ColumnIndex == dgvEmployes.Columns["modif"].Index)
            {
                int currentID = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                clsProduit produit = new clsProduit(dgvEmployes.Rows[e.RowIndex].Cells["nom"].Value.ToString(),
                    _PictureFileName,
                    dgvEmployes.Rows[e.RowIndex].Cells["etat"].Value.ToString()[0],
                    Convert.ToBoolean(dgvEmployes.Rows[e.RowIndex].Cells["fragile"].Value),
                    int.Parse(nudQte.Value.ToString()),
                    dateTimePicker1.Value);

                clsProduit.ListeProduits[clsProduit.recherche(currentID)] = produit;
                reloadDgv();
            }
            if(e.ColumnIndex == dgvEmployes.Columns["image"].Index)
            {
                openFileDialog1.ShowDialog();
                _PictureFileName = openFileDialog1.FileName;
                dgvEmployes.Rows[e.RowIndex].Cells["image"].Value = Image.FromFile(_PictureFileName);
                int id = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                clsProduit.ListeProduits[clsProduit.recherche(id)].PictureFilename = _PictureFileName;
            }
        }


       // On gère l'evenement lors du double click sur une case du dgvEmployes 
        private void dgvEmployes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //clsProduit produit = (clsProduit)dgvEmployes.CurrentRow.DataBoundItem;

            txtNom.Text = dgvEmployes.CurrentRow.Cells["nom"].Value.ToString();
            pctBoxPicture.Image = (Image)dgvEmployes.CurrentRow.Cells["image"].Value;
            chkBoxFragile.Checked = Convert.ToBoolean(dgvEmployes.CurrentRow.Cells["fragile"].Value);
            switch (dgvEmployes.CurrentRow.Cells["etat"].Value)
            {
                case "Livré":
                    cmbEtat.SelectedIndex = 0;
                    break;
                case "En attente":
                    cmbEtat.SelectedIndex = 1;
                    break;
                case "Retard":
                    cmbEtat.SelectedIndex = 2;
                    break;
            }

        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(dgvEmployes.CurrentRow.Cells["id"].Value.ToString());
            clsProduit produit = new clsProduit(txtNom.Text, _PictureFileName, cmbEtat.Text[0], chkBoxFragile.Checked, int.Parse(nudQte.Value.ToString()), dateTimePicker1.Value);
            clsProduit.ListeProduits[clsProduit.recherche(currentID)] = produit;
            reloadDgv();

        }

        private void dgvEmployes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvEmployes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvEmployes.CurrentCell)
            //{

            //}
            if (dgvEmployes.CurrentCell != null) {
                if (dgvEmployes.CurrentCell.ColumnIndex == dgvEmployes.Rows[e.RowIndex].Cells["nom"].ColumnIndex)
                {
                    int id = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    clsProduit.ListeProduits[clsProduit.recherche(id)].Nom = dgvEmployes.Rows[e.RowIndex].Cells["nom"].Value.ToString();
                }
                if (dgvEmployes.CurrentCell.ColumnIndex == dgvEmployes.Rows[e.RowIndex].Cells["fragile"].ColumnIndex)
                {
                    int id = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    clsProduit.ListeProduits[clsProduit.recherche(id)].Fragile = Convert.ToBoolean(dgvEmployes.Rows[e.RowIndex].Cells["fragile"].Value);
                }
                if (dgvEmployes.CurrentCell.ColumnIndex == dgvEmployes.Rows[e.RowIndex].Cells["etat"].ColumnIndex)
                {
                    int id = int.Parse(dgvEmployes.Rows[e.RowIndex].Cells["id"].Value.ToString());
                    clsProduit.ListeProduits[clsProduit.recherche(id)].Etat = dgvEmployes.Rows[e.RowIndex].Cells["etat"].Value.ToString()[0];
                }
            }
        }
    }
}
