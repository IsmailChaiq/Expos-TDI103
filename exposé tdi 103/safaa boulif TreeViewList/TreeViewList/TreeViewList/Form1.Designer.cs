
namespace TreeViewList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("amine");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nœud2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("kamal", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView = new System.Windows.Forms.TreeView();
            this.txtNomNoeud = new System.Windows.Forms.TextBox();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnNoeudPrinc = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnNoeudSec = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(15, 146);
            this.treeView.Margin = new System.Windows.Forms.Padding(4);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(432, 330);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCheck);
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCheck);
            // 
            // txtNomNoeud
            // 
            this.txtNomNoeud.Location = new System.Drawing.Point(131, 15);
            this.txtNomNoeud.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomNoeud.Name = "txtNomNoeud";
            this.txtNomNoeud.Size = new System.Drawing.Size(132, 22);
            this.txtNomNoeud.TabIndex = 1;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(244, 54);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(100, 84);
            this.btnSupp.TabIndex = 3;
            this.btnSupp.Text = "Supprimer le noeud selectionné";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnNoeudPrinc
            // 
            this.btnNoeudPrinc.Location = new System.Drawing.Point(12, 54);
            this.btnNoeudPrinc.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoeudPrinc.Name = "btnNoeudPrinc";
            this.btnNoeudPrinc.Size = new System.Drawing.Size(108, 84);
            this.btnNoeudPrinc.TabIndex = 5;
            this.btnNoeudPrinc.Text = "Ajouter un noeuds principale";
            this.btnNoeudPrinc.UseVisualStyleBackColor = true;
            this.btnNoeudPrinc.Click += new System.EventHandler(this.btnNoeudPrinc_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 18);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(109, 17);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom du noeud :";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNoeudSec
            // 
            this.btnNoeudSec.Location = new System.Drawing.Point(128, 54);
            this.btnNoeudSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnNoeudSec.Name = "btnNoeudSec";
            this.btnNoeudSec.Size = new System.Drawing.Size(108, 84);
            this.btnNoeudSec.TabIndex = 8;
            this.btnNoeudSec.Text = "Ajouter un noeuds secondaire";
            this.btnNoeudSec.UseVisualStyleBackColor = true;
            this.btnNoeudSec.Click += new System.EventHandler(this.btnNoeudSec_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(352, 54);
            this.btnModif.Margin = new System.Windows.Forms.Padding(4);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(105, 84);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier le nom du noeud selectionné";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(491, 146);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nœud0";
            treeNode1.Text = "amine";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "Nœud2";
            treeNode3.Name = "Nœud1";
            treeNode3.Text = "kamal";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(354, 328);
            this.treeView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 486);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnNoeudSec);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnNoeudPrinc);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.txtNomNoeud);
            this.Controls.Add(this.treeView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox txtNomNoeud;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnNoeudPrinc;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnNoeudSec;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.TreeView treeView1;
    }
}

