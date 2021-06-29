using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void DynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            MyUsercontrol[] listUserControl = new MyUsercontrol[5];

            string[] titre = new string[5]
            {
                "Fraise" ,"Banana" , "Orange" , "Pomme" , "Ananasa" 
            };

            string[] sousTitre = new string[5]
            {
                "Item 1" ,"Item 2" , "Item 3" , "Item 4" , "Item 5"
            };

            Image[] images = new Image[5]
            {
                Properties.Resources.fraise , Properties.Resources.banana ,Properties.Resources.orange ,Properties.Resources.Pomme , Properties.Resources.ananasa
            };

            for (int i = 0;  i < listUserControl.Length; i++)
            {
                listUserControl[i] = new MyUsercontrol();
                listUserControl[i].Titre = titre[i];
                listUserControl[i].SousTitre = sousTitre[i];
                listUserControl[i].Image = images[i];

                flowLayoutPanel1.Controls.Add(listUserControl[i]);


                listUserControl[i].Click += new System.EventHandler(this.UserControlClick);

                
            }



        }

        private void UserControlClick(object sender , EventArgs e)
        {
            MyUsercontrol uc = (MyUsercontrol)sender;
            _lblTitre.Text = uc.Titre;
            _lblSouTitre.Text = uc.SousTitre;
            _PicBox.Image = uc.Image;
            showPanel();
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DynamicUserControl();
        }

        private void showPanel()
        {
            panel.Visible = true;
        }
        private void hidePanel()
        {
            panel.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            hidePanel();
        }
    }
}
