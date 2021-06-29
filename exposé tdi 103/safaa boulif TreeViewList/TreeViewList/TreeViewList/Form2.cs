using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Checked && node.Name == "tptreeview")
                {
                    Form1 f = new Form1();
                    f.Show();
                }
                if (node.Nodes.Count > 0)
                {
                    foreach (TreeNode nod in node.Nodes)
                    {
                        if (nod.Checked && nod.Name == "tptreeview")
                        {
                            Form1 f = new Form1();
                            f.Show();
                        }

                    }
                    
                }
            }
            
        }
    }
}