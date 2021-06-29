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
    public partial class Propriétés_de_combo__1 : Form
    {
        public Propriétés_de_combo__1()
        {
            InitializeComponent();
        }

        private void Propriétés_de_combo_Load(object sender, EventArgs e)
        {
            ////Ajouter Des éléments dans la liste de ComboBox avec(Add)
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("Java");
            comboBox1.Items.Add("Python");

            //tableau
            //string[] liste = { "PHP", "HTML", "CSS" };
            //string[] T = liste;
            //comboBox1.Items.AddRange(T);

            //Hauteur largeur
            comboBox1.DropDownHeight = 50;
            comboBox1.DropDownWidth = 300;
            //Location =Top,Left
            comboBox1.Location = new System.Drawing.Point(70, 100);
            comboBox1.Size = new System.Drawing.Size(245, 25);
            comboBox1.BackColor = System.Drawing.Color.Blue;
            comboBox1.ForeColor = System.Drawing.Color.Black;       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
