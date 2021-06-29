using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        ListView listView1 = new ListView();
        ImageList I = new ImageList();


        private void Form1_Load(object sender, EventArgs e)
        {
            
            
                
                
                listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));

                
                listView1.View = View.Details;


                
                listView1.LabelEdit = true;


                
                listView1.AllowColumnReorder = true;


                
                listView1.CheckBoxes = true;


                
                listView1.FullRowSelect = true;


                
                listView1.GridLines = true;


                
                listView1.Sorting = SortOrder.Ascending;


            ListViewItem item1 = new ListViewItem("item1", 0);
            item1.Checked = true;
            item1.SubItems[0].Text = "Hamza";
            item1.SubItems.Add("Filahi");
            item1.SubItems.Add("18");


            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems[0].Text = "Samir";
            item2.SubItems.Add("Achouri");
            item2.SubItems.Add("18");


            listView1.Columns.Add("Nom", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Prenom", -2, HorizontalAlignment.Right);
            listView1.Columns.Add("Age", -2, HorizontalAlignment.Center);
            listView1.Items.AddRange(new ListViewItem[] { item1, item2 });


                


                I.Images.Add(Bitmap.FromFile("C:\\Pics\\Zoro.jpg"));
                I.Images.Add(Bitmap.FromFile("C:\\Pics\\Sukuna.jpg"));




                
                listView1.SmallImageList = I;


                this.Controls.Add(listView1);
            }
        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            //PB.Image = Image.I;
            PB.Image = I.Images[0];
        }
    }
}
