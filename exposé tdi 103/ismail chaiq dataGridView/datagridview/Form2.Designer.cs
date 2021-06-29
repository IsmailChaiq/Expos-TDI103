namespace datagridview
{
    partial class Form2
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
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.chkBoxFragile = new System.Windows.Forms.CheckBox();
            this.cmbEtat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pctBoxPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnParcourir = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQte = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.fragile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.supp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modif = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.AllowUserToAddRows = false;
            this.dgvEmployes.AllowUserToDeleteRows = false;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.id,
            this.nom,
            this.fragile,
            this.etat,
            this.supp,
            this.modif});
            this.dgvEmployes.Location = new System.Drawing.Point(12, 193);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.Size = new System.Drawing.Size(776, 245);
            this.dgvEmployes.TabIndex = 0;
            this.dgvEmployes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellClick);
            this.dgvEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellContentClick);
            this.dgvEmployes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellDoubleClick);
            this.dgvEmployes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEmployes_CellValidating);
            this.dgvEmployes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(200, 16);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // chkBoxFragile
            // 
            this.chkBoxFragile.AutoSize = true;
            this.chkBoxFragile.Location = new System.Drawing.Point(200, 50);
            this.chkBoxFragile.Name = "chkBoxFragile";
            this.chkBoxFragile.Size = new System.Drawing.Size(15, 14);
            this.chkBoxFragile.TabIndex = 5;
            this.chkBoxFragile.UseVisualStyleBackColor = true;
            // 
            // cmbEtat
            // 
            this.cmbEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtat.FormattingEnabled = true;
            this.cmbEtat.Items.AddRange(new object[] {
            "Livré",
            "En attente",
            "Retard"});
            this.cmbEtat.Location = new System.Drawing.Point(200, 79);
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Size = new System.Drawing.Size(80, 21);
            this.cmbEtat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fragile :";
            // 
            // pctBoxPicture
            // 
            this.pctBoxPicture.Location = new System.Drawing.Point(12, 16);
            this.pctBoxPicture.Name = "pctBoxPicture";
            this.pctBoxPicture.Size = new System.Drawing.Size(125, 125);
            this.pctBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxPicture.TabIndex = 9;
            this.pctBoxPicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnParcourir
            // 
            this.btnParcourir.Location = new System.Drawing.Point(12, 150);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(125, 23);
            this.btnParcourir.TabIndex = 10;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(221, 164);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(79, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantité : ";
            // 
            // nudQte
            // 
            this.nudQte.Location = new System.Drawing.Point(197, 106);
            this.nudQte.Name = "nudQte";
            this.nudQte.Size = new System.Drawing.Size(46, 20);
            this.nudQte.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(136, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date de commande: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(306, 163);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 18;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // image
            // 
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            // 
            // fragile
            // 
            this.fragile.HeaderText = "Fragile";
            this.fragile.Name = "fragile";
            // 
            // etat
            // 
            this.etat.HeaderText = "Etat";
            this.etat.Name = "etat";
            // 
            // supp
            // 
            this.supp.HeaderText = "Supprimer";
            this.supp.Name = "supp";
            this.supp.Text = "Supprimer";
            // 
            // modif
            // 
            this.modif.HeaderText = "Modifier";
            this.modif.Name = "modif";
            this.modif.Text = "Modifier";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQte);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnParcourir);
            this.Controls.Add(this.pctBoxPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEtat);
            this.Controls.Add(this.chkBoxFragile);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployes);
            this.Name = "Form2";
            this.Text = "Methode 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.CheckBox chkBoxFragile;
        private System.Windows.Forms.ComboBox cmbEtat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctBoxPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnParcourir;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fragile;
        private System.Windows.Forms.DataGridViewComboBoxColumn etat;
        private System.Windows.Forms.DataGridViewButtonColumn supp;
        private System.Windows.Forms.DataGridViewButtonColumn modif;
    }
}

