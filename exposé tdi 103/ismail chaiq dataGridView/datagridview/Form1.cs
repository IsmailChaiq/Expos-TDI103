using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string PictureFileName;
        private void Form1_Load(object sender, EventArgs e)
        {
            setupDgv();
        }
        private void btnParcourir_Click(object sender, EventArgs e)
        {
            // Affiche une fenetre pour selectionner l'image
            openFileDialog1.ShowDialog();
            PictureFileName = openFileDialog1.FileName;
            pctBoxPicture.Image = Image.FromFile(PictureFileName);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            clsProduit produit = new clsProduit(txtNom.Text, PictureFileName, cmbEtat.Text[0], chkBoxFragile.Checked, int.Parse(nudQte.Value.ToString()),dateTimePicker1.Value) ;
            clsProduit.ListeProduits.Add(produit);
            reloadDgv();


        }

        public void setupDgv()
        {
            dgvEmployes.RowHeadersVisible = false;

            dgvEmployes.Columns.Clear();
            dgvEmployes.DataSource = null;
            dgvEmployes.DataSource = clsProduit.ListeProduits;


            DataGridViewTextBoxColumn dgvTextColumn = new DataGridViewTextBoxColumn();
            dgvTextColumn.Name = "strEtat";
            dgvTextColumn.HeaderText = "Etat";
            dgvTextColumn.DisplayIndex = 3;


            // Instanciation de la colonne CheckBox du DataGridView
            DataGridViewCheckBoxColumn dgvCheckedColumn = new DataGridViewCheckBoxColumn();
            dgvCheckedColumn.Name = "chkFragile";
            dgvCheckedColumn.HeaderText = "Fragile";

            // Instanciation de la colonne Image du DataGridView
            DataGridViewImageColumn dgvPictureColumn = new DataGridViewImageColumn();
            dgvPictureColumn.Name = "Image";
            dgvPictureColumn.HeaderText = "Image";
            dgvPictureColumn.DisplayIndex = 0;
            dgvPictureColumn.Width = 100;
            dgvPictureColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            // Instanciation de la colonne ComboBox du DataGridView
            DataGridViewComboBoxColumn dgvCmbColumn = new DataGridViewComboBoxColumn();
            dgvCmbColumn.Name = "cmbEtat";
            dgvCmbColumn.HeaderText = "État";
            dgvCmbColumn.Items.Add("Livré");
            dgvCmbColumn.Items.Add("En attente");
            dgvCmbColumn.Items.Add("Retard");

            // Instanciation de la colonne Button du DataGridView
            DataGridViewButtonColumn dgvButtonColumn = new DataGridViewButtonColumn();
            dgvButtonColumn.Name = "Supprimer";
            dgvButtonColumn.HeaderText = "Supprimer";
            dgvButtonColumn.Text = "Supprimer";
            dgvButtonColumn.UseColumnTextForButtonValue = true;

            // Instanciation de la colonne NumericUpDown du DataGridView
            NumericUpDownColumn nud = new NumericUpDownColumn();
            nud.Name = "qte";
            nud.HeaderText = "Quantité";
            nud.DisplayIndex = 2;

            // Instanciation de la colonne DateTime du DataGridView
            DataGridViewColumn dtpColumn = new DataGridViewColumn();
            dtpColumn.Name = "date";
            dtpColumn.HeaderText = "Date commande";
            dtpColumn.ReadOnly = true;
            dtpColumn.CellTemplate = new DataGridViewDTPCell();

            // Desactive la visibilité des columns ajouté automatiquement lors l'utilisation du DataSource
            dgvEmployes.Columns["Fragile"].Visible = false;
            dgvEmployes.Columns["PictureFilename"].Visible = false;
            dgvEmployes.Columns["Etat"].Visible = false;
            dgvEmployes.Columns["str_Etat"].Visible = false;

            // Ajout des objets columns à la liste Columns du dgvEmployes

            dgvEmployes.Columns.Add(dgvTextColumn);
            dgvEmployes.Columns.Add(dgvCheckedColumn);
            dgvEmployes.Columns.Add(dgvCmbColumn);
            dgvEmployes.Columns.Add(dgvPictureColumn);
            dgvEmployes.Columns.Add(dgvButtonColumn);
            dgvEmployes.Columns.Add(nud);
            dgvEmployes.Columns.Add(dtpColumn);

        }

        public void reloadDgv()
        {
            setupDgv();

            //dgvEmployes.Columns["Fragile"].Visible = false;
            //dgvEmployes.Columns["PictureFilename"].Visible = false;
            //dgvEmployes.Columns["Etat"].Visible = false;

            // Modifie l'ordre d'affichage des deux columns
            dgvEmployes.Columns["Nom"].DisplayIndex = 1;


            foreach (DataGridViewRow row in dgvEmployes.Rows)
            {
                row.Height = 48;

                // Importe l'objet produit affecté à la ligne grace au DataSource
                clsProduit produit = row.DataBoundItem as clsProduit;

                // Importe la case image affecté à la ligne
                DataGridViewImageCell imageCell = row.Cells["Image"] as DataGridViewImageCell;
                imageCell.Value = Image.FromFile(produit.PictureFilename);

                DataGridViewTextBoxCell txtCell = row.Cells["strEtat"] as DataGridViewTextBoxCell;
                txtCell.Value = produit.str_Etat;
                switch (txtCell.Value)
                {
                    case "Livré":
                        txtCell.Style.ForeColor = Color.Green;
                        break;
                    case "En cours":
                        txtCell.Style.ForeColor = Color.Yellow;
                        break;
                    case "Retard":
                        txtCell.Style.ForeColor = Color.Red;
                        break;
                }

                DataGridViewCheckBoxCell chkCell = row.Cells["chkFragile"] as DataGridViewCheckBoxCell;
                if (produit.Fragile == true)
                {
                    // Affecte true à la case CheckBox
                    chkCell.Value = true;
                }
                else
                {
                    chkCell.Value = false;
                }

                DataGridViewComboBoxCell cmbCell = row.Cells["cmbEtat"] as DataGridViewComboBoxCell;
                switch (produit.Etat)
                {
                    case 'L':
                        cmbCell.Value = cmbCell.Items[0];
                        break;
                    case 'E':
                        cmbCell.Value = cmbCell.Items[1];
                        break;
                    case 'R':
                        cmbCell.Value = cmbCell.Items[2];
                        break;
                }

                NumericUpDownCell nudCell = row.Cells["qte"] as NumericUpDownCell;
                nudCell.Value = produit.qte;

                var dtpCell = row.Cells["date"]; // doit etre textBoxCell
                dtpCell.Value = produit.Date;



            }
        }

        /* L'objet DataGridViewButtonColumn n'a pas d'evenement gérer lors du click
           On gère l'evenement lors du click sur n'importe quelle case du dgvEmployes */

        private void dgvEmployes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /* L'objet e contient les arguments de l'evenement click 
               On compare l'indice de la colonne clické avec l'indice de la colonne du boutton */

            if (e.ColumnIndex == dgvEmployes.Columns["Supprimer"].Index)
            {
                clsProduit.ListeProduits.Remove((clsProduit)dgvEmployes.CurrentRow.DataBoundItem);
                reloadDgv();
            }
        }

        // On gère l'evenement lors du double click sur une case du dgvEmployes 
        private void dgvEmployes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            clsProduit produit = (clsProduit)dgvEmployes.CurrentRow.DataBoundItem;

            txtNom.Text = produit.Nom;
            pctBoxPicture.Image = Image.FromFile(produit.PictureFilename);
            chkBoxFragile.Checked = produit.Fragile;
            switch (produit.Etat)
            {
                case 'L':
                    cmbEtat.SelectedIndex = 0;
                    break;
                case 'E':
                    cmbEtat.SelectedIndex = 1;
                    break;
                case 'R':
                    cmbEtat.SelectedIndex = 2;
                    break;
            }

        }

        private void dgvEmployes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void setCellStyle(Control control)
        {
            foreach (Control ctl in control.Controls)
            {
                if (ctl is DataGridView)
                {
                    DataGridView dgv = ctl as DataGridView;


                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(159, 201, 243);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    dgv.EnableHeadersVisualStyles = false;

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(159, 201, 243);
                        }
                        else
                        {
                            dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(207, 228, 249);
                        }
                    }
                }
                if (ctl.Controls.Count > 0)
                {
                    setCellStyle(ctl);
                }
            }


        }

        private void dgvEmployes_DataSourceChanged(object sender, EventArgs e)
        {
            setCellStyle(this);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    class DataGridViewDTPCell : DataGridViewTextBoxCell
    {
        private DateTimePicker dtp = new DateTimePicker();

        public DateTimePicker Dtp { get => dtp; 
            set {
                dtp = value;

            } }
        public DataGridViewDTPCell()
        {

        }



    }
    public class NumericUpDownColumn : DataGridViewColumn
    {
        public NumericUpDownColumn() : base(new NumericUpDownCell())
        {
        }

        public NumericUpDownColumn(DataGridViewCell cell)
            : base(cell)
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }

            set
            {
                // Ensure that the cell used for the template is a NumericUpDownCell.
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
                {
                    throw new InvalidCastException("Must be a NumericUpDownCell");
                }
                base.CellTemplate = value;
            }
        }
    }


    public class NumericUpDownCell : DataGridViewTextBoxCell
    {
        public NumericUpDownCell()
        {
            this.Style.Format = "#";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            NumericUpDownEditingControl ctl = (NumericUpDownEditingControl)DataGridView.EditingControl;
            if (this.Value.ToString() != "")
            {
                ctl.Value = Convert.ToDecimal(this.Value);

            }
        }

        public override Type EditType
        {
            // Return the type of the editing contol that NumericUpDownCell uses.
            get { return typeof(NumericUpDownEditingControl); }
        }

        public override Type ValueType
        {
            // Return the type of the value that NumericUpDownCell contains.
            get { return typeof(int); }
        }

        public override object DefaultNewRowValue
        {
            // Default value for a newly added row in the grid
            get { return 0; }
        }
    }

    /// <summary>
    /// An auxilary class to NumericUpDownColumn that supplies the appropriate overridden interfaces to the normal NumericUpDown control.
    /// </summary>
    class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;
        protected bool initializing = false;

        public NumericUpDownEditingControl()
        {
            initializing = true;

            this.Minimum = (decimal)0;
            this.DecimalPlaces = 0;
            this.Maximum = 120;

            initializing = false;
        }

        virtual public object EditingControlFormattedValue
        {
            get { return this.Value.ToString("#"); }

            set
            {
                if (value is int)
                {
                    this.Value = int.Parse(Value.ToString());
                }
                else if (value is decimal)
                {
                    this.Value = decimal.Parse(value.ToString());
                }
                else
                {
                    this.Value = 0;
                }
            }
        }

        virtual public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Value.ToString("#");
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndexNum; }
            set { rowIndexNum = value; }
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridViewControl; }
            set { dataGridViewControl = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueIsChanged; }
            set { valueIsChanged = value; }
        }

        public System.Windows.Forms.Cursor EditingControlCursor
        {
            get { return base.Cursor; }
        }

        System.Windows.Forms.Cursor IDataGridViewEditingControl.EditingPanelCursor
        {
            get { return EditingControlCursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            if (!initializing) // Original code blew up without this
            {
                // Notify the DataGridView that the contents of the cell have changed.
                valueIsChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true); base.OnValueChanged(eventargs);
            }
        }
    }


    class DateTimePickerEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView dgvControl;
        private int indexRow;
        private bool valueChanged;
        bool initializing;

        public DateTimePickerEditingControl()
        {
            initializing = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "dateTimePicker1";
            this.Size = new System.Drawing.Size(16, 64);
            this.TabIndex = 14;

            initializing = false;

        }
        public DataGridView EditingControlDataGridView
        {
            get { return dgvControl; }
            set
            {
                dgvControl = value;
            }
        }


        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToString("f") ;
            }
            set
            {
                if (value is DateTime)
                {
                    this.Value = (DateTime)value;
                }
                else
                {
                    this.Value = DateTime.Now;
                }

            }
        }
        public int EditingControlRowIndex
        {
            get { return indexRow; }
            set
            {
                indexRow = value;
            }
        }

        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }
        public Cursor EditingControlCursor
        {
            get { return base.Cursor; }
        }
        public Cursor EditingPanelCursor
        {
            get { return EditingControlCursor; }
        }
        public bool RepositionEditingControlOnValueChange { get { return false; } }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public object GetEditingControlFormattedValue(System.Windows.Forms.DataGridViewDataErrorContexts context)
        {
            return this.Value.ToString("f");
        }
        public void PrepareEditingControlForEdit(bool selectAll)
        {

        }
    }

    class DateTimePickerDgvCell : DataGridViewCell
    {
        public DateTimePickerDgvCell()
        {
            this.Style.Format = "#";
        }
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DateTimePickerEditingControl ctl = (DateTimePickerEditingControl)DataGridView.EditingControl;
            ctl.Value = (DateTime)this.Value;
        }

        public override Type EditType
        {
            get { return typeof(DateTimePickerEditingControl); }
        }
        public override Type ValueType
        {
            get { return typeof(DateTime); }
        }
        public override object DefaultNewRowValue
        {
            get { return 0; }

        }

    }
    public class DateTimePickerDgvColumn : DataGridViewColumn
    {
        public DateTimePickerDgvColumn(): base(new DateTimePickerDgvCell()) { }
        public DateTimePickerDgvColumn(DataGridViewCell cell) : base(cell) { }
        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }

            set
            {
                // Ensure that the cell used for the template is a NumericUpDownCell.
                if ((value != null) && !value.GetType().IsAssignableFrom(typeof(DateTimePickerDgvCell)))
                {
                    throw new InvalidCastException("Doit être de type DateTimePickerCell");
                }
                base.CellTemplate = value;
            }
        }
    }


}
