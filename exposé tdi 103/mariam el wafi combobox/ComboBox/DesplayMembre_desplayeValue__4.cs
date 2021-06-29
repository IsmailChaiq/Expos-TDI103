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
    public partial class DesplayMembre_desplayeValue__4 : Form
    {
        public DesplayMembre_desplayeValue__4()
        {
            InitializeComponent();
        }
        public void remplir()
        {
            
        }
        private void Frmsaisir_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo obj = comboBox2.SelectedItem as Combo;
            if( obj != null)
            {
                label4.Text = obj.prenom + " " + "est une "+ " "+comboBox1.SelectedItem;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //remplissage de combobox1
            string[] listes = { "célibataire", "marié", "veuf", "divorce" };
            string[] T = listes;
            comboBox1.Items.AddRange(T);
            //SelectedIndex
            comboBox1.SelectedIndex = 0;
            //remplissage de combobox2
            List<Combo> listecombo = new List<Combo>();
            listecombo.Add(new Combo() { nom = "el wafi", prenom = " mariam" });
            listecombo.Add(new Combo() { nom = "alaoui", prenom = " marewa" });
            listecombo.Add(new Combo() { nom = "al habti", prenom = " asmaa" });
            listecombo.Add(new Combo() { nom = "al amerani", prenom = " sameya" });
            listecombo.Add(new Combo() { nom = "alami", prenom = " chaimaa" });
            comboBox2.DataSource = listecombo;
            comboBox2.DisplayMember = "prenom";
            comboBox2.ValueMember = "nom";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int  c = comboBox1.Items.Count;
            MessageBox.Show("le nembre de combobox1 c'est" + c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
