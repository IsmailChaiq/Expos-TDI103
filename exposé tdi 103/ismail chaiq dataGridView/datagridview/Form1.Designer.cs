namespace datagridview
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
            this.nudQte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
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
            this.dgvEmployes.Location = new System.Drawing.Point(12, 210);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.Size = new System.Drawing.Size(776, 228);
            this.dgvEmployes.TabIndex = 0;
            this.dgvEmployes.DataSourceChanged += new System.EventHandler(this.dgvEmployes_DataSourceChanged);
            this.dgvEmployes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellClick);
            this.dgvEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellContentClick);
            this.dgvEmployes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellDoubleClick);
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
            this.txtNom.Location = new System.Drawing.Point(224, 15);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // chkBoxFragile
            // 
            this.chkBoxFragile.AutoSize = true;
            this.chkBoxFragile.Location = new System.Drawing.Point(224, 45);
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
            this.cmbEtat.Location = new System.Drawing.Point(224, 69);
            this.cmbEtat.Name = "cmbEtat";
            this.cmbEtat.Size = new System.Drawing.Size(80, 21);
            this.cmbEtat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Etat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 46);
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
            this.btnParcourir.Location = new System.Drawing.Point(12, 146);
            this.btnParcourir.Name = "btnParcourir";
            this.btnParcourir.Size = new System.Drawing.Size(125, 23);
            this.btnParcourir.TabIndex = 10;
            this.btnParcourir.Text = "Parcourir";
            this.btnParcourir.UseVisualStyleBackColor = true;
            this.btnParcourir.Click += new System.EventHandler(this.btnParcourir_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(221, 181);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(79, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nudQte
            // 
            this.nudQte.Location = new System.Drawing.Point(221, 100);
            this.nudQte.Name = "nudQte";
            this.nudQte.Size = new System.Drawing.Size(46, 20);
            this.nudQte.TabIndex = 12;
            this.nudQte.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantité : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(143, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date de commande: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.NumericUpDown nudQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}

