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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            treeView.CheckBoxes = true;
        }

        private void btnNoeudPrinc_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Add(txtNomNoeud.Text);
        }

        private void btnNoeudSec_Click(object sender, EventArgs e)
        {
            if(treeView.SelectedNode != null)
            {
                treeView.SelectedNode.Nodes.Add(txtNomNoeud.Text);
                
                if(treeView.SelectedNode.IsExpanded == false)
                {
                    treeView.SelectedNode.Expand();
                }
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            SupprimerCheckedNodes(treeView1.Nodes);
        }
        
        

        private void treeView_AfterCheck(object sender, TreeViewEventArgs e)
        {

            
        }

        private void treeView_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Checked == true)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        node.Checked = false;
                    }
                }
            }
            else
            {
                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        node.Checked = true;
                    }
                }
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            //if(treeView.SelectedNode != null)
            //{
            //    treeView.SelectedNode.Text = txtNomNoeud.Text;
            //}
            RenomerCheckedNodes(treeView.Nodes);
        }

        private List<TreeNode> ListeNodesChecked = new List<TreeNode>();
        private void SupprimerCheckedNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    ListeNodesChecked.Add(node);

                }
                else
                {
                    SupprimerCheckedNodes(node.Nodes);
                }
            }
            foreach (TreeNode CheckedNode in ListeNodesChecked)
            {
                nodes.Remove(CheckedNode);
            }
        }
        private void RenomerCheckedNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    node.Text = txtNomNoeud.Text;
                }
                if (node.Nodes.Count > 0)
                {

                    RenomerCheckedNodes(node.Nodes);
                }
            }
        }

    }
}
