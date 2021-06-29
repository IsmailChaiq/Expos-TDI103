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
    public partial class MyUsercontrol : UserControl
    {
        public MyUsercontrol()
        {
            InitializeComponent();
        }

        private Image image;
        private string titre;
        private string soustitre;


        public Image Image
        {
            get
            {
                return image; 
            }
            set
            {
                image = value;
                PicBox.Image = value;
            }
        }




        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                titre = value;
                lblTitre.Text = value;
            }
        }




        public string SousTitre
        {
            get
            {
                return soustitre;
            }
            set
            {
                soustitre = value;
                lblSouTitre.Text = soustitre;
            }
        }



       
        private void MyUsercontrol_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }



        private void MyUsercontrol_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255 , 255);
        }
    }
}
