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
    public partial class ucmembre : UserControl
    {
        public ucmembre()
        {
            InitializeComponent();
        }

        public event Action ViderLesChamps;



        public void viderchamps()
        {
            TXTadresse.Text = "";
            TXTnumero.Text = "";
            TXTtele.Text = "";
            TXTnomcomplet.Text = "";
        }




        public string nom { get => TXTnomcomplet.Text; set => TXTnumero.Text = value; }
        public string numero { get => TXTnumero.Text; set => TXTnumero.Text = value; }
        public string adresse { get => TXTadresse.Text; set => TXTadresse.Text = value; }
        public string tele { get => TXTtele.Text; set => TXTtele.Text = value; }







        private void txtchanged(object sender, EventArgs e)
        {
            ucbutton.Show();
            ucbutton.BringToFront();
            
        }

        private void ucmembre_Load(object sender, EventArgs e)
        {
            ucbutton.Hide();
            


        }

 

        private void ucbutton_btnOnclick(object sender, EventArgs e)
        {
            membre m = new membre(nom, numero, tele, adresse);
            m.ajouter(m);
           
            

        }

      




























        //public event EventHandler ChangerUSerCotrol;

        //protected virtual void OnchangerUC(EventArgs e)
        //{
        //    ChangerUSerCotrol.Invoke(this, e);
        //}
    }
}
