
namespace checked_list_box
{
    partial class TP_Checked_list_box
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
            this.ckb1 = new System.Windows.Forms.CheckedListBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnverification = new System.Windows.Forms.Button();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btntransfert = new System.Windows.Forms.Button();
            this.cbcocheztout = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckb1
            // 
            this.ckb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ckb1.FormattingEnabled = true;
            this.ckb1.Location = new System.Drawing.Point(383, 59);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(360, 272);
            this.ckb1.TabIndex = 0;
            this.ckb1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnajouter
            // 
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(126, 378);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(175, 49);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(303, 378);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(175, 49);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnverification
            // 
            this.btnverification.FlatAppearance.BorderSize = 0;
            this.btnverification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverification.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverification.Location = new System.Drawing.Point(481, 378);
            this.btnverification.Name = "btnverification";
            this.btnverification.Size = new System.Drawing.Size(247, 49);
            this.btnverification.TabIndex = 4;
            this.btnverification.Text = "L\'indice des cases cochées";
            this.btnverification.UseVisualStyleBackColor = true;
            this.btnverification.Click += new System.EventHandler(this.btnverification_Click);
            // 
            // txtitems
            // 
            this.txtitems.Location = new System.Drawing.Point(30, 44);
            this.txtitems.Multiline = true;
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(252, 46);
            this.txtitems.TabIndex = 5;
            // 
            // lb1
            // 
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(761, 58);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(362, 272);
            this.lb1.TabIndex = 6;
            // 
            // btntransfert
            // 
            this.btntransfert.FlatAppearance.BorderSize = 0;
            this.btntransfert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransfert.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransfert.Location = new System.Drawing.Point(732, 378);
            this.btntransfert.Name = "btntransfert";
            this.btntransfert.Size = new System.Drawing.Size(228, 48);
            this.btntransfert.TabIndex = 7;
            this.btntransfert.Text = "Tansfert a une liste box";
            this.btntransfert.UseVisualStyleBackColor = true;
            this.btntransfert.Click += new System.EventHandler(this.btntransfert_Click);
            // 
            // cbcocheztout
            // 
            this.cbcocheztout.AutoSize = true;
            this.cbcocheztout.FlatAppearance.BorderSize = 0;
            this.cbcocheztout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcocheztout.Font = new System.Drawing.Font("Lucida Bright", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcocheztout.Location = new System.Drawing.Point(387, 22);
            this.cbcocheztout.Name = "cbcocheztout";
            this.cbcocheztout.Size = new System.Drawing.Size(133, 23);
            this.cbcocheztout.TabIndex = 8;
            this.cbcocheztout.Text = "Cochez tout";
            this.cbcocheztout.UseVisualStyleBackColor = true;
            this.cbcocheztout.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TP_Checked_list_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 450);
            this.Controls.Add(this.cbcocheztout);
            this.Controls.Add(this.btntransfert);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.txtitems);
            this.Controls.Add(this.btnverification);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.ckb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TP_Checked_list_box";
            this.Text = "TP_Checked_list_box";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckb1;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnverification;
        private System.Windows.Forms.TextBox txtitems;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Button btntransfert;
        private System.Windows.Forms.CheckBox cbcocheztout;
    }
}

