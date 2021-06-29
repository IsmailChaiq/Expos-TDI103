using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checked_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //---------Change le mode de sélection du double-clic au simple clic-------
            checkedListBox1.CheckOnClick = true;
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(txtitems.Text.ToUpper());
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(txtitems.Text.ToUpper());
        }

        private void btnverification_Click(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show("Index: " + indexChecked.ToString() + ",et coché . Checked state et:" +
                                checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //---Le boutton pour Cochez tout les elements de la liste------
            checkedListBox1.Items.Add("Cochez tout", CheckState.Unchecked);
            //-----------remplir la liste par defaut----------
           
            //checkedListBox1.Items.Add("Lundi", CheckState.Checked);
            //checkedListBox1.Items.Add("Mardi", CheckState.Unchecked);
            //checkedListBox1.Items.Add("Jeudi", CheckState.Indeterminate);

            //-------la liaison d'une datasource à checkedlistbox-----

            //DataTable dt = new DataTable();
            //DataColumn dc = new DataColumn("StringType", typeof(String));
            //dt.Columns.Add(dc);
            //DataRow dr = dt.NewRow();
            //dr[0] = "Item_1";
            //dt.Rows.Add(dr);
            //this.checkedListBox1.DataSource = dt;
            //this.checkedListBox1.DisplayMember = "StringType";

            ////-----------verifier si les elements sont non vérifiés--------

            //checkedListBox1.Items.Add("Lundi", CheckState.Checked);
            //checkedListBox1.Items.Add("Mardi", CheckState.Checked);
            //checkedListBox1.Items.Add("Jeudi", CheckState.Checked);
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, false);
            //}

            ////---------verifier si les elements sont vérifiés--------

            //string[] jours = new[] { "Lundi", "Mardi", "Jeudi" };
            //checkedListBox1.Items.AddRange(jours);
            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    checkedListBox1.SetItemChecked(i, true);
            //}

        }

        private void btntransfert_Click(object sender, EventArgs e)
        {
                
                listBox1.Items.Clear();
                btntransfert.Enabled = false;
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
                }
                if (listBox1.Items.Count > 0)
                {
                    btntransfert.Enabled = true;
                }
                    
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

       
        //----Les méthodes d'activer le boutton Cochez tout au milieu de la liste------------
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (e.NewValue == CheckState.Checked)
                    ChangeAllCheckBoxValues(true);
                else
                    ChangeAllCheckBoxValues(false);
            }
        }
        private void ChangeAllCheckBoxValues(bool value)
        {
            for (int i = 1; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, value);
            }
        }
    }
}
