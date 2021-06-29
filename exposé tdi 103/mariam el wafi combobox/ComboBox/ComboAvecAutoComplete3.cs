using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace ComboBox
{
    public partial class ComboAvecAutoComplete3 : Form
    {
        //SqlConnection con;
        //SqlDataAdapter da;
        //DataTable dt = new DataTable();
        public ComboAvecAutoComplete3()
        {
            InitializeComponent();
            //con = new SqlConnection(@"Server=.\SQLEXPRESS;Database=DB_AC; Integrated Security=true");
            //da = new SqlDataAdapter("Select * from tbl_customers", con);
            //da.Fill(dt);
            //AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            //for (int i = 0; i < dt.Rows.Count; i++)

            //{
            //    datasource.Add(dt.Rows[i][0].ToString());

            //}
            //this.comboBox1.AutoCompleteCustomSource = datasource;
            //this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            List<ClsPersonneADRS> listedesPersonne = new List<ClsPersonneADRS>();
            listedesPersonne.Add(new ClsPersonneADRS() { Nom = "Mariam", Email = "mariam@gmail.com" });
            listedesPersonne.Add(new ClsPersonneADRS() { Nom = "alaou", Email = "alaou@gmail.com" });
            listedesPersonne.Add(new ClsPersonneADRS() { Nom = "mohamed", Email = "mohamed@gmail.com" });
            listedesPersonne.Add(new ClsPersonneADRS() { Nom = "salma", Email = "salma@gmail.com" });
            listedesPersonne.Add(new ClsPersonneADRS() { Nom = "mouhcine", Email = "mouhcine@gmail.com" });
            comboBox4.DataSource = listedesPersonne;
            comboBox4.DisplayMember = "Nom";
        }

        private void ComboAvecAutoComplete_Load(object sender, EventArgs e)
        {

            //Ajouter Des éléments dans la liste de ComboBox avec(Add)
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("Java");
            comboBox1.Items.Add("Python");
            

            //combo2
            string[] liste = { "PHP", "HTML", "CSS" };
            comboBox2.DataSource =liste;

            //combo3
            string[] listes = { "PHP", "HTML", "CSS" ,"c#","Java","Python"};
            string[] T = listes;
            comboBox3.DataSource = T;
            




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClsPersonneADRS pr = comboBox4.SelectedItem as ClsPersonneADRS;
            textBox1.Text = pr.Email.ToString();
            

        }
    }
}
