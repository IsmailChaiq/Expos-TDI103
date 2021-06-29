
namespace user_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel = new System.Windows.Forms.Panel();
            this._PicBox = new System.Windows.Forms.PictureBox();
            this._lblSouTitre = new System.Windows.Forms.Label();
            this._lblTitre = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 923);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnOK);
            this.panel.Controls.Add(this._PicBox);
            this.panel.Controls.Add(this._lblSouTitre);
            this.panel.Controls.Add(this._lblTitre);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(413, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(545, 920);
            this.panel.TabIndex = 1;
            // 
            // _PicBox
            // 
            this._PicBox.Location = new System.Drawing.Point(210, 79);
            this._PicBox.Name = "_PicBox";
            this._PicBox.Size = new System.Drawing.Size(186, 169);
            this._PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._PicBox.TabIndex = 6;
            this._PicBox.TabStop = false;
            // 
            // _lblSouTitre
            // 
            this._lblSouTitre.AutoSize = true;
            this._lblSouTitre.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblSouTitre.Location = new System.Drawing.Point(254, 307);
            this._lblSouTitre.Name = "_lblSouTitre";
            this._lblSouTitre.Size = new System.Drawing.Size(106, 27);
            this._lblSouTitre.TabIndex = 8;
            this._lblSouTitre.Text = "Sous titre";
            // 
            // _lblTitre
            // 
            this._lblTitre.AutoSize = true;
            this._lblTitre.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTitre.Location = new System.Drawing.Point(262, 251);
            this._lblTitre.Name = "_lblTitre";
            this._lblTitre.Size = new System.Drawing.Size(87, 44);
            this._lblTitre.TabIndex = 7;
            this._lblTitre.Text = "titre";
            // 
            // btnOK
            // 
            this.btnOK.AllowAnimations = true;
            this.btnOK.AllowMouseEffects = true;
            this.btnOK.AllowToggling = false;
            this.btnOK.AnimationSpeed = 200;
            this.btnOK.AutoGenerateColors = false;
            this.btnOK.AutoRoundBorders = true;
            this.btnOK.AutoSizeLeftIcon = true;
            this.btnOK.AutoSizeRightIcon = true;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackColor1 = System.Drawing.Color.SlateBlue;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.ButtonText = "Ok";
            this.btnOK.ButtonTextMarginLeft = 0;
            this.btnOK.ColorContrastOnClick = 45;
            this.btnOK.ColorContrastOnHover = 45;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnOK.CustomizableEdges = borderEdges4;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOK.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOK.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOK.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOK.IconMarginLeft = 11;
            this.btnOK.IconPadding = 10;
            this.btnOK.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOK.IconSize = 25;
            this.btnOK.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnOK.IdleBorderRadius = 37;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleFillColor = System.Drawing.Color.SlateBlue;
            this.btnOK.IdleIconLeftImage = null;
            this.btnOK.IdleIconRightImage = null;
            this.btnOK.IndicateFocus = false;
            this.btnOK.Location = new System.Drawing.Point(342, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOK.OnDisabledState.BorderRadius = 1;
            this.btnOK.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnDisabledState.BorderThickness = 1;
            this.btnOK.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOK.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOK.OnDisabledState.IconLeftImage = null;
            this.btnOK.OnDisabledState.IconRightImage = null;
            this.btnOK.onHoverState.BorderColor = System.Drawing.Color.Violet;
            this.btnOK.onHoverState.BorderRadius = 1;
            this.btnOK.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.onHoverState.BorderThickness = 1;
            this.btnOK.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnOK.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOK.onHoverState.IconLeftImage = null;
            this.btnOK.onHoverState.IconRightImage = null;
            this.btnOK.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnOK.OnIdleState.BorderRadius = 1;
            this.btnOK.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnIdleState.BorderThickness = 1;
            this.btnOK.OnIdleState.FillColor = System.Drawing.Color.SlateBlue;
            this.btnOK.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOK.OnIdleState.IconLeftImage = null;
            this.btnOK.OnIdleState.IconRightImage = null;
            this.btnOK.OnPressedState.BorderColor = System.Drawing.Color.Purple;
            this.btnOK.OnPressedState.BorderRadius = 1;
            this.btnOK.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOK.OnPressedState.BorderThickness = 1;
            this.btnOK.OnPressedState.FillColor = System.Drawing.Color.Purple;
            this.btnOK.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOK.OnPressedState.IconLeftImage = null;
            this.btnOK.OnPressedState.IconRightImage = null;
            this.btnOK.Size = new System.Drawing.Size(150, 39);
            this.btnOK.TabIndex = 162;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.TextMarginLeft = 0;
            this.btnOK.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOK.UseDefaultRadiusAndThickness = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 920);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox _PicBox;
        private System.Windows.Forms.Label _lblSouTitre;
        private System.Windows.Forms.Label _lblTitre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOK;
    }
}