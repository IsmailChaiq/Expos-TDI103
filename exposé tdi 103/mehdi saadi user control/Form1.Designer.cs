
namespace user_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.BTNVente = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTNutilisateur = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTNMembre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BTNstatistique = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ucmembre1 = new user_control.ucmembre();
            this.ucgrid1 = new user_control.ucgrid();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.BTNVente);
            this.bunifuPanel1.Controls.Add(this.BTNutilisateur);
            this.bunifuPanel1.Controls.Add(this.BTNMembre);
            this.bunifuPanel1.Controls.Add(this.BTNstatistique);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(267, 483);
            this.bunifuPanel1.TabIndex = 157;
            // 
            // BTNVente
            // 
            this.BTNVente.AllowAnimations = true;
            this.BTNVente.AllowMouseEffects = true;
            this.BTNVente.AllowToggling = false;
            this.BTNVente.AnimationSpeed = 200;
            this.BTNVente.AutoGenerateColors = false;
            this.BTNVente.AutoRoundBorders = false;
            this.BTNVente.AutoSizeLeftIcon = true;
            this.BTNVente.AutoSizeRightIcon = true;
            this.BTNVente.BackColor = System.Drawing.Color.Transparent;
            this.BTNVente.BackColor1 = System.Drawing.Color.White;
            this.BTNVente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNVente.BackgroundImage")));
            this.BTNVente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNVente.ButtonText = "Vente";
            this.BTNVente.ButtonTextMarginLeft = 0;
            this.BTNVente.ColorContrastOnClick = 45;
            this.BTNVente.ColorContrastOnHover = 45;
            this.BTNVente.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BTNVente.CustomizableEdges = borderEdges1;
            this.BTNVente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNVente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNVente.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNVente.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNVente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTNVente.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVente.ForeColor = System.Drawing.Color.DimGray;
            this.BTNVente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNVente.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTNVente.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTNVente.IconMarginLeft = 11;
            this.BTNVente.IconPadding = 10;
            this.BTNVente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNVente.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTNVente.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTNVente.IconSize = 25;
            this.BTNVente.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BTNVente.IdleBorderRadius = 1;
            this.BTNVente.IdleBorderThickness = 1;
            this.BTNVente.IdleFillColor = System.Drawing.Color.White;
            this.BTNVente.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNVente.IdleIconLeftImage")));
            this.BTNVente.IdleIconRightImage = null;
            this.BTNVente.IndicateFocus = false;
            this.BTNVente.Location = new System.Drawing.Point(0, 591);
            this.BTNVente.Name = "BTNVente";
            this.BTNVente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNVente.OnDisabledState.BorderRadius = 1;
            this.BTNVente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNVente.OnDisabledState.BorderThickness = 1;
            this.BTNVente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNVente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNVente.OnDisabledState.IconLeftImage = null;
            this.BTNVente.OnDisabledState.IconRightImage = null;
            this.BTNVente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNVente.onHoverState.BorderRadius = 1;
            this.BTNVente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNVente.onHoverState.BorderThickness = 1;
            this.BTNVente.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNVente.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTNVente.onHoverState.IconLeftImage = null;
            this.BTNVente.onHoverState.IconRightImage = null;
            this.BTNVente.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.BTNVente.OnIdleState.BorderRadius = 1;
            this.BTNVente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNVente.OnIdleState.BorderThickness = 1;
            this.BTNVente.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BTNVente.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.BTNVente.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNVente.OnIdleState.IconLeftImage")));
            this.BTNVente.OnIdleState.IconRightImage = null;
            this.BTNVente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNVente.OnPressedState.BorderRadius = 1;
            this.BTNVente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNVente.OnPressedState.BorderThickness = 1;
            this.BTNVente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNVente.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTNVente.OnPressedState.IconLeftImage = null;
            this.BTNVente.OnPressedState.IconRightImage = null;
            this.BTNVente.Size = new System.Drawing.Size(267, 53);
            this.BTNVente.TabIndex = 159;
            this.BTNVente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNVente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNVente.TextMarginLeft = 0;
            this.BTNVente.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTNVente.UseDefaultRadiusAndThickness = true;
            // 
            // BTNutilisateur
            // 
            this.BTNutilisateur.AllowAnimations = true;
            this.BTNutilisateur.AllowMouseEffects = true;
            this.BTNutilisateur.AllowToggling = false;
            this.BTNutilisateur.AnimationSpeed = 200;
            this.BTNutilisateur.AutoGenerateColors = false;
            this.BTNutilisateur.AutoRoundBorders = false;
            this.BTNutilisateur.AutoSizeLeftIcon = true;
            this.BTNutilisateur.AutoSizeRightIcon = true;
            this.BTNutilisateur.BackColor = System.Drawing.Color.Transparent;
            this.BTNutilisateur.BackColor1 = System.Drawing.Color.White;
            this.BTNutilisateur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNutilisateur.BackgroundImage")));
            this.BTNutilisateur.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNutilisateur.ButtonText = "Utilisateurs";
            this.BTNutilisateur.ButtonTextMarginLeft = 0;
            this.BTNutilisateur.ColorContrastOnClick = 45;
            this.BTNutilisateur.ColorContrastOnHover = 45;
            this.BTNutilisateur.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BTNutilisateur.CustomizableEdges = borderEdges2;
            this.BTNutilisateur.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNutilisateur.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNutilisateur.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNutilisateur.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNutilisateur.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTNutilisateur.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNutilisateur.ForeColor = System.Drawing.Color.DimGray;
            this.BTNutilisateur.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNutilisateur.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTNutilisateur.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTNutilisateur.IconMarginLeft = 11;
            this.BTNutilisateur.IconPadding = 10;
            this.BTNutilisateur.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNutilisateur.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTNutilisateur.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTNutilisateur.IconSize = 25;
            this.BTNutilisateur.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BTNutilisateur.IdleBorderRadius = 1;
            this.BTNutilisateur.IdleBorderThickness = 1;
            this.BTNutilisateur.IdleFillColor = System.Drawing.Color.White;
            this.BTNutilisateur.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNutilisateur.IdleIconLeftImage")));
            this.BTNutilisateur.IdleIconRightImage = null;
            this.BTNutilisateur.IndicateFocus = false;
            this.BTNutilisateur.Location = new System.Drawing.Point(0, 643);
            this.BTNutilisateur.Name = "BTNutilisateur";
            this.BTNutilisateur.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNutilisateur.OnDisabledState.BorderRadius = 1;
            this.BTNutilisateur.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNutilisateur.OnDisabledState.BorderThickness = 1;
            this.BTNutilisateur.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNutilisateur.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNutilisateur.OnDisabledState.IconLeftImage = null;
            this.BTNutilisateur.OnDisabledState.IconRightImage = null;
            this.BTNutilisateur.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNutilisateur.onHoverState.BorderRadius = 1;
            this.BTNutilisateur.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNutilisateur.onHoverState.BorderThickness = 1;
            this.BTNutilisateur.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNutilisateur.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTNutilisateur.onHoverState.IconLeftImage = null;
            this.BTNutilisateur.onHoverState.IconRightImage = null;
            this.BTNutilisateur.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.BTNutilisateur.OnIdleState.BorderRadius = 1;
            this.BTNutilisateur.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNutilisateur.OnIdleState.BorderThickness = 1;
            this.BTNutilisateur.OnIdleState.FillColor = System.Drawing.Color.White;
            this.BTNutilisateur.OnIdleState.ForeColor = System.Drawing.Color.DimGray;
            this.BTNutilisateur.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNutilisateur.OnIdleState.IconLeftImage")));
            this.BTNutilisateur.OnIdleState.IconRightImage = null;
            this.BTNutilisateur.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNutilisateur.OnPressedState.BorderRadius = 1;
            this.BTNutilisateur.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNutilisateur.OnPressedState.BorderThickness = 1;
            this.BTNutilisateur.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNutilisateur.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTNutilisateur.OnPressedState.IconLeftImage = null;
            this.BTNutilisateur.OnPressedState.IconRightImage = null;
            this.BTNutilisateur.Size = new System.Drawing.Size(267, 53);
            this.BTNutilisateur.TabIndex = 15;
            this.BTNutilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNutilisateur.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNutilisateur.TextMarginLeft = 0;
            this.BTNutilisateur.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTNutilisateur.UseDefaultRadiusAndThickness = true;
            // 
            // BTNMembre
            // 
            this.BTNMembre.AllowAnimations = true;
            this.BTNMembre.AllowMouseEffects = true;
            this.BTNMembre.AllowToggling = false;
            this.BTNMembre.AnimationSpeed = 200;
            this.BTNMembre.AutoGenerateColors = false;
            this.BTNMembre.AutoRoundBorders = false;
            this.BTNMembre.AutoSizeLeftIcon = true;
            this.BTNMembre.AutoSizeRightIcon = true;
            this.BTNMembre.BackColor = System.Drawing.Color.Transparent;
            this.BTNMembre.BackColor1 = System.Drawing.Color.Gray;
            this.BTNMembre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNMembre.BackgroundImage")));
            this.BTNMembre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNMembre.ButtonText = "Member";
            this.BTNMembre.ButtonTextMarginLeft = 0;
            this.BTNMembre.ColorContrastOnClick = 45;
            this.BTNMembre.ColorContrastOnHover = 45;
            this.BTNMembre.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BTNMembre.CustomizableEdges = borderEdges3;
            this.BTNMembre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNMembre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNMembre.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNMembre.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNMembre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTNMembre.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMembre.ForeColor = System.Drawing.Color.White;
            this.BTNMembre.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMembre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTNMembre.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTNMembre.IconMarginLeft = 11;
            this.BTNMembre.IconPadding = 10;
            this.BTNMembre.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMembre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTNMembre.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTNMembre.IconSize = 25;
            this.BTNMembre.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BTNMembre.IdleBorderRadius = 1;
            this.BTNMembre.IdleBorderThickness = 1;
            this.BTNMembre.IdleFillColor = System.Drawing.Color.Gray;
            this.BTNMembre.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNMembre.IdleIconLeftImage")));
            this.BTNMembre.IdleIconRightImage = null;
            this.BTNMembre.IndicateFocus = false;
            this.BTNMembre.Location = new System.Drawing.Point(0, 201);
            this.BTNMembre.Name = "BTNMembre";
            this.BTNMembre.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNMembre.OnDisabledState.BorderRadius = 1;
            this.BTNMembre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNMembre.OnDisabledState.BorderThickness = 1;
            this.BTNMembre.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNMembre.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNMembre.OnDisabledState.IconLeftImage = null;
            this.BTNMembre.OnDisabledState.IconRightImage = null;
            this.BTNMembre.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNMembre.onHoverState.BorderRadius = 1;
            this.BTNMembre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNMembre.onHoverState.BorderThickness = 1;
            this.BTNMembre.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNMembre.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTNMembre.onHoverState.IconLeftImage = null;
            this.BTNMembre.onHoverState.IconRightImage = null;
            this.BTNMembre.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.BTNMembre.OnIdleState.BorderRadius = 1;
            this.BTNMembre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNMembre.OnIdleState.BorderThickness = 1;
            this.BTNMembre.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.BTNMembre.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BTNMembre.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNMembre.OnIdleState.IconLeftImage")));
            this.BTNMembre.OnIdleState.IconRightImage = null;
            this.BTNMembre.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNMembre.OnPressedState.BorderRadius = 1;
            this.BTNMembre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNMembre.OnPressedState.BorderThickness = 1;
            this.BTNMembre.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNMembre.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTNMembre.OnPressedState.IconLeftImage = null;
            this.BTNMembre.OnPressedState.IconRightImage = null;
            this.BTNMembre.Size = new System.Drawing.Size(267, 53);
            this.BTNMembre.TabIndex = 7;
            this.BTNMembre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNMembre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNMembre.TextMarginLeft = 0;
            this.BTNMembre.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTNMembre.UseDefaultRadiusAndThickness = true;
            this.BTNMembre.Click += new System.EventHandler(this.BTNMembre_Click);
            // 
            // BTNstatistique
            // 
            this.BTNstatistique.AllowAnimations = true;
            this.BTNstatistique.AllowMouseEffects = true;
            this.BTNstatistique.AllowToggling = false;
            this.BTNstatistique.AnimationSpeed = 200;
            this.BTNstatistique.AutoGenerateColors = false;
            this.BTNstatistique.AutoRoundBorders = false;
            this.BTNstatistique.AutoSizeLeftIcon = true;
            this.BTNstatistique.AutoSizeRightIcon = true;
            this.BTNstatistique.BackColor = System.Drawing.Color.Transparent;
            this.BTNstatistique.BackColor1 = System.Drawing.Color.Gray;
            this.BTNstatistique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNstatistique.BackgroundImage")));
            this.BTNstatistique.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNstatistique.ButtonText = "Data";
            this.BTNstatistique.ButtonTextMarginLeft = 0;
            this.BTNstatistique.ColorContrastOnClick = 45;
            this.BTNstatistique.ColorContrastOnHover = 45;
            this.BTNstatistique.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.BTNstatistique.CustomizableEdges = borderEdges4;
            this.BTNstatistique.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BTNstatistique.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNstatistique.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNstatistique.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNstatistique.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BTNstatistique.Font = new System.Drawing.Font("Agency FB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNstatistique.ForeColor = System.Drawing.Color.White;
            this.BTNstatistique.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNstatistique.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BTNstatistique.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BTNstatistique.IconMarginLeft = 11;
            this.BTNstatistique.IconPadding = 10;
            this.BTNstatistique.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNstatistique.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BTNstatistique.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BTNstatistique.IconSize = 25;
            this.BTNstatistique.IdleBorderColor = System.Drawing.Color.Transparent;
            this.BTNstatistique.IdleBorderRadius = 1;
            this.BTNstatistique.IdleBorderThickness = 1;
            this.BTNstatistique.IdleFillColor = System.Drawing.Color.Gray;
            this.BTNstatistique.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNstatistique.IdleIconLeftImage")));
            this.BTNstatistique.IdleIconRightImage = null;
            this.BTNstatistique.IndicateFocus = false;
            this.BTNstatistique.Location = new System.Drawing.Point(-3, 125);
            this.BTNstatistique.Name = "BTNstatistique";
            this.BTNstatistique.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BTNstatistique.OnDisabledState.BorderRadius = 1;
            this.BTNstatistique.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNstatistique.OnDisabledState.BorderThickness = 1;
            this.BTNstatistique.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BTNstatistique.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BTNstatistique.OnDisabledState.IconLeftImage = null;
            this.BTNstatistique.OnDisabledState.IconRightImage = null;
            this.BTNstatistique.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNstatistique.onHoverState.BorderRadius = 1;
            this.BTNstatistique.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNstatistique.onHoverState.BorderThickness = 1;
            this.BTNstatistique.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BTNstatistique.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BTNstatistique.onHoverState.IconLeftImage = null;
            this.BTNstatistique.onHoverState.IconRightImage = null;
            this.BTNstatistique.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.BTNstatistique.OnIdleState.BorderRadius = 1;
            this.BTNstatistique.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.BTNstatistique.OnIdleState.BorderThickness = 1;
            this.BTNstatistique.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.BTNstatistique.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BTNstatistique.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("BTNstatistique.OnIdleState.IconLeftImage")));
            this.BTNstatistique.OnIdleState.IconRightImage = null;
            this.BTNstatistique.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNstatistique.OnPressedState.BorderRadius = 1;
            this.BTNstatistique.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BTNstatistique.OnPressedState.BorderThickness = 1;
            this.BTNstatistique.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BTNstatistique.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BTNstatistique.OnPressedState.IconLeftImage = null;
            this.BTNstatistique.OnPressedState.IconRightImage = null;
            this.BTNstatistique.Size = new System.Drawing.Size(270, 53);
            this.BTNstatistique.TabIndex = 6;
            this.BTNstatistique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNstatistique.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BTNstatistique.TextMarginLeft = 0;
            this.BTNstatistique.TextPadding = new System.Windows.Forms.Padding(0);
            this.BTNstatistique.UseDefaultRadiusAndThickness = true;
            this.BTNstatistique.Click += new System.EventHandler(this.BTNstatistique_Click);
            // 
            // ucmembre1
            // 
            this.ucmembre1.adresse = "";
            this.ucmembre1.BackColor = System.Drawing.Color.White;
            this.ucmembre1.Location = new System.Drawing.Point(273, 0);
            this.ucmembre1.Name = "ucmembre1";
            this.ucmembre1.numero = "";
            this.ucmembre1.Size = new System.Drawing.Size(934, 490);
            this.ucmembre1.TabIndex = 159;
            this.ucmembre1.tele = "";
            // 
            // ucgrid1
            // 
            this.ucgrid1.Location = new System.Drawing.Point(273, -7);
            this.ucgrid1.Name = "ucgrid1";
            this.ucgrid1.Size = new System.Drawing.Size(934, 490);
            this.ucgrid1.TabIndex = 158;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 483);
            this.Controls.Add(this.ucmembre1);
            this.Controls.Add(this.ucgrid1);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTNVente;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTNutilisateur;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTNMembre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BTNstatistique;
        private ucgrid ucgrid1;
        private ucmembre ucmembre1;
    }
}

