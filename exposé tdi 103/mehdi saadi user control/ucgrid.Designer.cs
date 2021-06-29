
namespace user_control
{
    partial class ucgrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucgrid));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.datatagrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoir = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.datatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // datatagrid
            // 
            this.datatagrid.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datatagrid.ColumnHeadersHeight = 40;
            this.datatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.Telephone,
            this.Adresse});
            this.datatagrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.datatagrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datatagrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datatagrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datatagrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datatagrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datatagrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datatagrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.datatagrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datatagrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datatagrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.datatagrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datatagrid.CurrentTheme.Name = null;
            this.datatagrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datatagrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datatagrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datatagrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datatagrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.datatagrid.EnableHeadersVisualStyles = false;
            this.datatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datatagrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.datatagrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.datatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.datatagrid.Location = new System.Drawing.Point(3, 223);
            this.datatagrid.Name = "datatagrid";
            this.datatagrid.RowHeadersVisible = false;
            this.datatagrid.RowHeadersWidth = 62;
            this.datatagrid.RowTemplate.Height = 40;
            this.datatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datatagrid.Size = new System.Drawing.Size(931, 264);
            this.datatagrid.TabIndex = 0;
            this.datatagrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 8;
            this.Telephone.Name = "Telephone";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 8;
            this.Adresse.Name = "Adresse";
            // 
            // btnVoir
            // 
            this.btnVoir.AllowAnimations = true;
            this.btnVoir.AllowMouseEffects = true;
            this.btnVoir.AllowToggling = false;
            this.btnVoir.AnimationSpeed = 200;
            this.btnVoir.AutoGenerateColors = false;
            this.btnVoir.AutoRoundBorders = true;
            this.btnVoir.AutoSizeLeftIcon = true;
            this.btnVoir.AutoSizeRightIcon = true;
            this.btnVoir.BackColor = System.Drawing.Color.Transparent;
            this.btnVoir.BackColor1 = System.Drawing.Color.SlateBlue;
            this.btnVoir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoir.BackgroundImage")));
            this.btnVoir.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVoir.ButtonText = "Voir";
            this.btnVoir.ButtonTextMarginLeft = 0;
            this.btnVoir.ColorContrastOnClick = 45;
            this.btnVoir.ColorContrastOnHover = 45;
            this.btnVoir.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnVoir.CustomizableEdges = borderEdges1;
            this.btnVoir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVoir.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVoir.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVoir.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVoir.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnVoir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoir.ForeColor = System.Drawing.Color.White;
            this.btnVoir.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoir.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnVoir.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnVoir.IconMarginLeft = 11;
            this.btnVoir.IconPadding = 10;
            this.btnVoir.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoir.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnVoir.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVoir.IconSize = 25;
            this.btnVoir.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnVoir.IdleBorderRadius = 58;
            this.btnVoir.IdleBorderThickness = 1;
            this.btnVoir.IdleFillColor = System.Drawing.Color.SlateBlue;
            this.btnVoir.IdleIconLeftImage = null;
            this.btnVoir.IdleIconRightImage = null;
            this.btnVoir.IndicateFocus = false;
            this.btnVoir.Location = new System.Drawing.Point(703, 67);
            this.btnVoir.Name = "btnVoir";
            this.btnVoir.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVoir.OnDisabledState.BorderRadius = 1;
            this.btnVoir.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVoir.OnDisabledState.BorderThickness = 1;
            this.btnVoir.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVoir.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVoir.OnDisabledState.IconLeftImage = null;
            this.btnVoir.OnDisabledState.IconRightImage = null;
            this.btnVoir.onHoverState.BorderColor = System.Drawing.Color.Violet;
            this.btnVoir.onHoverState.BorderRadius = 1;
            this.btnVoir.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVoir.onHoverState.BorderThickness = 1;
            this.btnVoir.onHoverState.FillColor = System.Drawing.Color.Violet;
            this.btnVoir.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVoir.onHoverState.IconLeftImage = null;
            this.btnVoir.onHoverState.IconRightImage = null;
            this.btnVoir.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVoir.OnIdleState.BorderRadius = 1;
            this.btnVoir.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVoir.OnIdleState.BorderThickness = 1;
            this.btnVoir.OnIdleState.FillColor = System.Drawing.Color.SlateBlue;
            this.btnVoir.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVoir.OnIdleState.IconLeftImage = null;
            this.btnVoir.OnIdleState.IconRightImage = null;
            this.btnVoir.OnPressedState.BorderColor = System.Drawing.Color.Purple;
            this.btnVoir.OnPressedState.BorderRadius = 1;
            this.btnVoir.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnVoir.OnPressedState.BorderThickness = 1;
            this.btnVoir.OnPressedState.FillColor = System.Drawing.Color.Purple;
            this.btnVoir.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVoir.OnPressedState.IconLeftImage = null;
            this.btnVoir.OnPressedState.IconRightImage = null;
            this.btnVoir.Size = new System.Drawing.Size(211, 60);
            this.btnVoir.TabIndex = 161;
            this.btnVoir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoir.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVoir.TextMarginLeft = 0;
            this.btnVoir.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnVoir.UseDefaultRadiusAndThickness = true;
            this.btnVoir.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // ucgrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVoir);
            this.Controls.Add(this.datatagrid);
            this.Name = "ucgrid";
            this.Size = new System.Drawing.Size(934, 490);
            ((System.ComponentModel.ISupportInitialize)(this.datatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView datatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnVoir;
    }
}
