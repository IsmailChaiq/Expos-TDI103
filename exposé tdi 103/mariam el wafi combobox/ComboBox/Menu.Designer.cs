
namespace ComboBox
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proPriétésDeComboboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCompletedAutoModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desplayMembreValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicePourAfficherLageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proPriétésDeComboboxToolStripMenuItem,
            this.collectionToolStripMenuItem,
            this.autoCompletedAutoModeToolStripMenuItem,
            this.desplayMembreValueToolStripMenuItem,
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem,
            this.exercicePourAfficherLageToolStripMenuItem,
            this.comboToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // proPriétésDeComboboxToolStripMenuItem
            // 
            this.proPriétésDeComboboxToolStripMenuItem.Name = "proPriétésDeComboboxToolStripMenuItem";
            this.proPriétésDeComboboxToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.proPriétésDeComboboxToolStripMenuItem.Text = "ProPriétés De Combobox";
            this.proPriétésDeComboboxToolStripMenuItem.Click += new System.EventHandler(this.proPriétésDeComboboxToolStripMenuItem_Click);
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.collectionToolStripMenuItem.Text = "Collection";
            this.collectionToolStripMenuItem.Click += new System.EventHandler(this.collectionToolStripMenuItem_Click_1);
            // 
            // autoCompletedAutoModeToolStripMenuItem
            // 
            this.autoCompletedAutoModeToolStripMenuItem.Name = "autoCompletedAutoModeToolStripMenuItem";
            this.autoCompletedAutoModeToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.autoCompletedAutoModeToolStripMenuItem.Text = "AutoCompleted+AutoMode";
            this.autoCompletedAutoModeToolStripMenuItem.Click += new System.EventHandler(this.autoCompletedAutoModeToolStripMenuItem_Click);
            // 
            // desplayMembreValueToolStripMenuItem
            // 
            this.desplayMembreValueToolStripMenuItem.Name = "desplayMembreValueToolStripMenuItem";
            this.desplayMembreValueToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.desplayMembreValueToolStripMenuItem.Text = "DesplayMembre+Value";
            this.desplayMembreValueToolStripMenuItem.Click += new System.EventHandler(this.desplayMembreValueToolStripMenuItem_Click);
            // 
            // remplissageDuneComboAPartireDeTexteboxToolStripMenuItem
            // 
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem.Name = "remplissageDuneComboAPartireDeTexteboxToolStripMenuItem";
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem.Text = "remplissage d\'une combo a partire de textebox";
            this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem.Click += new System.EventHandler(this.remplissageDuneComboAPartireDeTexteboxToolStripMenuItem_Click);
            // 
            // exercicePourAfficherLageToolStripMenuItem
            // 
            this.exercicePourAfficherLageToolStripMenuItem.Name = "exercicePourAfficherLageToolStripMenuItem";
            this.exercicePourAfficherLageToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.exercicePourAfficherLageToolStripMenuItem.Text = "Exercice pour afficher l\'age";
            this.exercicePourAfficherLageToolStripMenuItem.Click += new System.EventHandler(this.exercicePourAfficherLageToolStripMenuItem_Click);
            // 
            // comboToolStripMenuItem
            // 
            this.comboToolStripMenuItem.Name = "comboToolStripMenuItem";
            this.comboToolStripMenuItem.Size = new System.Drawing.Size(322, 22);
            this.comboToolStripMenuItem.Text = "Combo";
            this.comboToolStripMenuItem.Click += new System.EventHandler(this.comboToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(758, 371);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "FrmcomboCllection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proPriétésDeComboboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoCompletedAutoModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desplayMembreValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remplissageDuneComboAPartireDeTexteboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicePourAfficherLageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboToolStripMenuItem;
    }
}