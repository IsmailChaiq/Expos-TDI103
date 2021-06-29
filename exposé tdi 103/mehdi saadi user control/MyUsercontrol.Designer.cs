
namespace user_control
{
    partial class MyUsercontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyUsercontrol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSouTitre = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.PicBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 165);
            this.panel1.TabIndex = 0;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(19, 13);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(150, 139);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(215, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(87, 44);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "titre";
            // 
            // lblSouTitre
            // 
            this.lblSouTitre.AutoSize = true;
            this.lblSouTitre.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSouTitre.Location = new System.Drawing.Point(218, 68);
            this.lblSouTitre.Name = "lblSouTitre";
            this.lblSouTitre.Size = new System.Drawing.Size(106, 27);
            this.lblSouTitre.TabIndex = 2;
            this.lblSouTitre.Text = "Sous titre";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Gray;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 169);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(428, 10);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // MyUsercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.lblSouTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel1);
            this.Name = "MyUsercontrol";
            this.Size = new System.Drawing.Size(428, 179);

            this.MouseEnter += new System.EventHandler(this.MyUsercontrol_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MyUsercontrol_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSouTitre;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
    }
}
