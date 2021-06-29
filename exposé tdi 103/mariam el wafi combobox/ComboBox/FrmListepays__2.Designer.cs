
namespace ComboBox
{
    partial class FrmListepays__2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbpayseE = new System.Windows.Forms.ComboBox();
            this.lblpayse = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.ListBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.lbprenom = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbpayseE
            // 
            this.cmbpayseE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbpayseE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpayseE.FormattingEnabled = true;
            this.cmbpayseE.Items.AddRange(new object[] {
            "  France",
            "  Ukraine",
            "  Espagne",
            "  Suède",
            "  Allemagne",
            "  Finlande",
            "  Norvège",
            "  Pologne",
            "  Italie",
            "  Royaume-Uni",
            "  Roumanie",
            "  Irlande",
            " "});
            this.cmbpayseE.Location = new System.Drawing.Point(191, 89);
            this.cmbpayseE.Name = "cmbpayseE";
            this.cmbpayseE.Size = new System.Drawing.Size(121, 21);
            this.cmbpayseE.TabIndex = 0;
            this.cmbpayseE.SelectedIndexChanged += new System.EventHandler(this.cmbpayseE_SelectedIndexChanged);
            // 
            // lblpayse
            // 
            this.lblpayse.AutoSize = true;
            this.lblpayse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpayse.Location = new System.Drawing.Point(5, 84);
            this.lblpayse.Name = "lblpayse";
            this.lblpayse.Size = new System.Drawing.Size(180, 24);
            this.lblpayse.TabIndex = 3;
            this.lblpayse.Text = "Pays europienne :";
            // 
            // liste
            // 
            this.liste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(343, 1);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(279, 199);
            this.liste.TabIndex = 4;
            this.liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(191, 20);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(121, 20);
            this.txtnom.TabIndex = 9;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(191, 50);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(121, 20);
            this.txtprenom.TabIndex = 10;
            // 
            // lbprenom
            // 
            this.lbprenom.AutoSize = true;
            this.lbprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprenom.Location = new System.Drawing.Point(12, 45);
            this.lbprenom.Name = "lbprenom";
            this.lbprenom.Size = new System.Drawing.Size(95, 24);
            this.lbprenom.TabIndex = 11;
            this.lbprenom.Text = "Prenom :";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(41, 16);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(66, 24);
            this.lblnom.TabIndex = 12;
            this.lblnom.Text = "Nom :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListepays__2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lbprenom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.lblpayse);
            this.Controls.Add(this.cmbpayseE);
            this.Name = "FrmListepays__2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListepays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbpayseE;
        private System.Windows.Forms.Label lblpayse;
        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label lbprenom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button button1;
    }
}

