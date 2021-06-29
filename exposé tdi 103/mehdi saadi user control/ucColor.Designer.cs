
namespace user_control
{
    partial class ucColor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRouge = new System.Windows.Forms.TrackBar();
            this.tbVert = new System.Windows.Forms.TrackBar();
            this.tbBleu = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRouge
            // 
            this.tbRouge.Location = new System.Drawing.Point(39, 42);
            this.tbRouge.Maximum = 235;
            this.tbRouge.Name = "tbRouge";
            this.tbRouge.Size = new System.Drawing.Size(376, 69);
            this.tbRouge.TabIndex = 1;
            this.tbRouge.TickFrequency = 5;
            this.tbRouge.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbVert
            // 
            this.tbVert.Location = new System.Drawing.Point(39, 142);
            this.tbVert.Maximum = 235;
            this.tbVert.Name = "tbVert";
            this.tbVert.Size = new System.Drawing.Size(376, 69);
            this.tbVert.TabIndex = 2;
            this.tbVert.TickFrequency = 5;
            this.tbVert.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // tbBleu
            // 
            this.tbBleu.Location = new System.Drawing.Point(39, 237);
            this.tbBleu.Maximum = 235;
            this.tbBleu.Name = "tbBleu";
            this.tbBleu.Size = new System.Drawing.Size(376, 69);
            this.tbBleu.TabIndex = 3;
            this.tbBleu.TickFrequency = 5;
            this.tbBleu.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rouge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bleu";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlColor.Location = new System.Drawing.Point(39, 321);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(376, 128);
            this.pnlColor.TabIndex = 7;
            // 
            // ucColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBleu);
            this.Controls.Add(this.tbVert);
            this.Controls.Add(this.tbRouge);
            this.Name = "ucColor";
            this.Size = new System.Drawing.Size(476, 465);
            ((System.ComponentModel.ISupportInitialize)(this.tbRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRouge;
        private System.Windows.Forms.TrackBar tbVert;
        private System.Windows.Forms.TrackBar tbBleu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlColor;
    }
}
