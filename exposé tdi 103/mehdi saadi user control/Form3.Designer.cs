
namespace user_control
{
    partial class Form3
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
            this.txtRouge = new System.Windows.Forms.TextBox();
            this.txtVert = new System.Windows.Forms.TextBox();
            this.txtblue = new System.Windows.Forms.TextBox();
            this.ucColor1 = new user_control.ucColor();
            this.SuspendLayout();
            // 
            // txtRouge
            // 
            this.txtRouge.Location = new System.Drawing.Point(550, 78);
            this.txtRouge.Name = "txtRouge";
            this.txtRouge.Size = new System.Drawing.Size(140, 26);
            this.txtRouge.TabIndex = 1;
            // 
            // txtVert
            // 
            this.txtVert.Location = new System.Drawing.Point(550, 171);
            this.txtVert.Name = "txtVert";
            this.txtVert.Size = new System.Drawing.Size(140, 26);
            this.txtVert.TabIndex = 2;
            // 
            // txtblue
            // 
            this.txtblue.Location = new System.Drawing.Point(550, 269);
            this.txtblue.Name = "txtblue";
            this.txtblue.Size = new System.Drawing.Size(140, 26);
            this.txtblue.TabIndex = 3;
            // 
            // ucColor1
            // 
            this.ucColor1.ControlColor = System.Drawing.Color.Empty;
            this.ucColor1.Location = new System.Drawing.Point(39, 33);
            this.ucColor1.Name = "ucColor1";
            this.ucColor1.Size = new System.Drawing.Size(476, 465);
            this.ucColor1.TabIndex = 4;
            this.ucColor1.ColourChange += new System.EventHandler(this.ucColor1_ColourChange);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 549);
            this.Controls.Add(this.ucColor1);
            this.Controls.Add(this.txtblue);
            this.Controls.Add(this.txtVert);
            this.Controls.Add(this.txtRouge);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRouge;
        private System.Windows.Forms.TextBox txtVert;
        private System.Windows.Forms.TextBox txtblue;
        private ucColor ucColor1;
    }
}