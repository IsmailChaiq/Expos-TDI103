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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void cmbpysa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void proPriétésDeComboboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Propriétés_de_combo__1 c = new Propriétés_de_combo__1();
            c.Show();
        }

        private void collectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void collectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmListepays__2 f = new FrmListepays__2();
            f.Show();
        }

        private void autoCompletedAutoModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboAvecAutoComplete3 D = new ComboAvecAutoComplete3();
            D.Show();
        }

        private void desplayMembreValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesplayMembre_desplayeValue__4 D = new DesplayMembre_desplayeValue__4();
            D.Show();
      }

        private void exercicePourAfficherLageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercice_pour_Calculer_et_afficher_votre_age Age = new Exercice_pour_Calculer_et_afficher_votre_age();
            Age.Show();
        }

        private void remplissageDuneComboAPartireDeTexteboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remplissage_d_une_combobox_a_d_autre_combobox c = new Remplissage_d_une_combobox_a_d_autre_combobox();
            c.Show();
        }

        private void comboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBOX1 c = new comboBOX1();
            c.Show();
        }
    }
}
