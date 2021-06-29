
namespace ComboBox
{
    partial class Exercice_pour_Calculer_et_afficher_votre_age
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
            this.Calculer = new System.Windows.Forms.Button();
            this.Quitter = new System.Windows.Forms.Button();
            this.ComboAnnée = new System.Windows.Forms.ComboBox();
            this.comboJours = new System.Windows.Forms.ComboBox();
            this.comboMois = new System.Windows.Forms.ComboBox();
            this.Afficher = new System.Windows.Forms.Button();
            this.Mois = new System.Windows.Forms.Label();
            this.Jour = new System.Windows.Forms.Label();
            this.Année = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculer
            // 
            this.Calculer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calculer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Calculer.Location = new System.Drawing.Point(165, 142);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(100, 37);
            this.Calculer.TabIndex = 0;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = false;
            this.Calculer.Click += new System.EventHandler(this.Calculer_Click);
            // 
            // Quitter
            // 
            this.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quitter.Location = new System.Drawing.Point(326, 142);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(100, 37);
            this.Quitter.TabIndex = 1;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = false;
            this.Quitter.Click += new System.EventHandler(this.Quitter_Click);
            // 
            // ComboAnnée
            // 
            this.ComboAnnée.FormattingEnabled = true;
            this.ComboAnnée.Location = new System.Drawing.Point(326, 39);
            this.ComboAnnée.Name = "ComboAnnée";
            this.ComboAnnée.Size = new System.Drawing.Size(121, 21);
            this.ComboAnnée.TabIndex = 2;
            // 
            // comboJours
            // 
            this.comboJours.FormattingEnabled = true;
            this.comboJours.Location = new System.Drawing.Point(165, 39);
            this.comboJours.Name = "comboJours";
            this.comboJours.Size = new System.Drawing.Size(121, 21);
            this.comboJours.TabIndex = 3;
            // 
            // comboMois
            // 
            this.comboMois.FormattingEnabled = true;
            this.comboMois.Location = new System.Drawing.Point(12, 39);
            this.comboMois.Name = "comboMois";
            this.comboMois.Size = new System.Drawing.Size(121, 21);
            this.comboMois.TabIndex = 4;
            // 
            // Afficher
            // 
            this.Afficher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Afficher.Location = new System.Drawing.Point(12, 142);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(100, 37);
            this.Afficher.TabIndex = 5;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = false;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // Mois
            // 
            this.Mois.AutoSize = true;
            this.Mois.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mois.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mois.Location = new System.Drawing.Point(43, 9);
            this.Mois.Name = "Mois";
            this.Mois.Size = new System.Drawing.Size(54, 24);
            this.Mois.TabIndex = 6;
            this.Mois.Text = "Mois";
            // 
            // Jour
            // 
            this.Jour.AutoSize = true;
            this.Jour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Jour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Jour.Location = new System.Drawing.Point(197, 9);
            this.Jour.Name = "Jour";
            this.Jour.Size = new System.Drawing.Size(61, 24);
            this.Jour.TabIndex = 7;
            this.Jour.Text = "Jours";
            // 
            // Année
            // 
            this.Année.AutoSize = true;
            this.Année.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Année.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Année.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Année.Location = new System.Drawing.Point(352, 9);
            this.Année.Name = "Année";
            this.Année.Size = new System.Drawing.Size(82, 24);
            this.Année.TabIndex = 8;
            this.Année.Text = "Années";
            // 
            // Exercice_pour_Calculer_et_afficher_votre_age
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(512, 191);
            this.Controls.Add(this.Année);
            this.Controls.Add(this.Jour);
            this.Controls.Add(this.Mois);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.comboMois);
            this.Controls.Add(this.comboJours);
            this.Controls.Add(this.ComboAnnée);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.Calculer);
            this.Name = "Exercice_pour_Calculer_et_afficher_votre_age";
            this.Text = "Exercice_pour_Calculer_et_afficher_votre_age";
            this.Load += new System.EventHandler(this.Exercice_pour_Calculer_et_afficher_votre_age_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculer;
        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.ComboBox ComboAnnée;
        private System.Windows.Forms.ComboBox comboJours;
        private System.Windows.Forms.ComboBox comboMois;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.Label Mois;
        private System.Windows.Forms.Label Jour;
        private System.Windows.Forms.Label Année;
    }
}