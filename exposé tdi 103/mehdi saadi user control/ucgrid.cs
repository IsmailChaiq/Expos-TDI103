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
    public partial class ucgrid : UserControl
    {
        public ucgrid()
        {
            InitializeComponent();
        }
        public void RemplirGridStagiaires()
        {

            ucmembre m = new ucmembre();
            for (int i = 0; i < liste.lstmembre.Count; i++)
            {
                datatagrid.Rows.Add();

                datatagrid.Rows[i].Cells["Nom"].Value = liste.lstmembre[i].Name;
                datatagrid.Rows[i].Cells["ID"].Value = liste.lstmembre[i].Numero;
                datatagrid.Rows[i].Cells["Adresse"].Value = liste.lstmembre[i].Adresse;
                datatagrid.Rows[i].Cells["Telephone"].Value = liste.lstmembre[i].Telephone;




            }
        }
       
        
        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            RemplirGridStagiaires();
        }
    }
}
