
namespace checked_list_box
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnverification = new System.Windows.Forms.Button();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btntransfert = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(383, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(360, 276);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
           
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(95, 378);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(175, 49);
            this.btnajouter.TabIndex = 1;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.Location = new System.Drawing.Point(288, 378);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(175, 49);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnverification
            // 
            this.btnverification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(770, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 276);
            this.listBox1.TabIndex = 6;
            // 
            // btntransfert
            // 
            this.btntransfert.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransfert.Location = new System.Drawing.Point(782, 381);
            this.btntransfert.Name = "btntransfert";
            this.btntransfert.Size = new System.Drawing.Size(228, 45);
            this.btntransfert.TabIndex = 7;
            this.btntransfert.Text = "Tansfert a une liste box";
            this.btntransfert.UseVisualStyleBackColor = true;
            this.btntransfert.Click += new System.EventHandler(this.btntransfert_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(387, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btntransfert);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtitems);
            this.Controls.Add(this.btnverification);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnverification;
        private System.Windows.Forms.TextBox txtitems;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btntransfert;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

