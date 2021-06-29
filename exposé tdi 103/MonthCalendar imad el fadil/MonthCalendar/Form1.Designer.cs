
namespace MonthCalendar
{
    partial class Form1
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
            this.Calendrier = new System.Windows.Forms.MonthCalendar();
            this.btntrimestre = new System.Windows.Forms.Button();
            this.btnAnnee = new System.Windows.Forms.Button();
            this.btnsemestre = new System.Windows.Forms.Button();
            this.btnMois = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(85, 85);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.TabIndex = 0;
            this.Calendrier.TodayDate = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            this.Calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btntrimestre
            // 
            this.btntrimestre.Location = new System.Drawing.Point(85, 26);
            this.btntrimestre.Name = "btntrimestre";
            this.btntrimestre.Size = new System.Drawing.Size(75, 23);
            this.btntrimestre.TabIndex = 1;
            this.btntrimestre.Text = "Trimestre";
            this.btntrimestre.UseVisualStyleBackColor = true;
            this.btntrimestre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnee
            // 
            this.btnAnnee.Location = new System.Drawing.Point(327, 26);
            this.btnAnnee.Name = "btnAnnee";
            this.btnAnnee.Size = new System.Drawing.Size(75, 23);
            this.btnAnnee.TabIndex = 2;
            this.btnAnnee.Text = "Annee";
            this.btnAnnee.UseVisualStyleBackColor = true;
            this.btnAnnee.Click += new System.EventHandler(this.btnAnnee_Click);
            // 
            // btnsemestre
            // 
            this.btnsemestre.Location = new System.Drawing.Point(200, 26);
            this.btnsemestre.Name = "btnsemestre";
            this.btnsemestre.Size = new System.Drawing.Size(75, 23);
            this.btnsemestre.TabIndex = 3;
            this.btnsemestre.Text = "Semestre";
            this.btnsemestre.UseVisualStyleBackColor = true;
            this.btnsemestre.Click += new System.EventHandler(this.btnsemestre_Click);
            // 
            // btnMois
            // 
            this.btnMois.Location = new System.Drawing.Point(432, 26);
            this.btnMois.Name = "btnMois";
            this.btnMois.Size = new System.Drawing.Size(75, 23);
            this.btnMois.TabIndex = 4;
            this.btnMois.Text = "Mois";
            this.btnMois.UseVisualStyleBackColor = true;
            this.btnMois.Click += new System.EventHandler(this.btnMois_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(488, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(488, 174);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(100, 20);
            this.txtTitre.TabIndex = 6;
            this.txtTitre.Text = "Titre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(528, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnMois);
            this.Controls.Add(this.btnsemestre);
            this.Controls.Add(this.btnAnnee);
            this.Controls.Add(this.btntrimestre);
            this.Controls.Add(this.Calendrier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendrier;
        private System.Windows.Forms.Button btntrimestre;
        private System.Windows.Forms.Button btnAnnee;
        private System.Windows.Forms.Button btnsemestre;
        private System.Windows.Forms.Button btnMois;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

