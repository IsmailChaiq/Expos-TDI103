
namespace Chart_c_sharpe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.checkF = new System.Windows.Forms.CheckBox();
            this.checkM = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoad.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(155, 197);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 54);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chartSalary
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSalary.Legends.Add(legend1);
            this.chartSalary.Location = new System.Drawing.Point(405, 12);
            this.chartSalary.Name = "chartSalary";
            this.chartSalary.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.chartSalary.Series.Add(series1);
            this.chartSalary.Series.Add(series2);
            this.chartSalary.Size = new System.Drawing.Size(450, 426);
            this.chartSalary.TabIndex = 2;
            this.chartSalary.Text = "ChartSalary";
            title1.Name = "Salary";
            title1.Text = "Salary";
            this.chartSalary.Titles.Add(title1);
            this.chartSalary.Click += new System.EventHandler(this.chartSalary_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(21, 17);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(72, 31);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(27, 60);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(119, 43);
            this.txtNom.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(265, 60);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(119, 43);
            this.txtAge.TabIndex = 6;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(259, 17);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 31);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAjouter.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(27, 197);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 54);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Location = new System.Drawing.Point(27, 288);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.Size = new System.Drawing.Size(357, 150);
            this.dgvPersonne.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(283, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 54);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(21, 145);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(58, 31);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sex";
            // 
            // checkF
            // 
            this.checkF.AutoSize = true;
            this.checkF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkF.Location = new System.Drawing.Point(118, 145);
            this.checkF.Name = "checkF";
            this.checkF.Size = new System.Drawing.Size(51, 35);
            this.checkF.TabIndex = 13;
            this.checkF.Text = "F";
            this.checkF.UseVisualStyleBackColor = true;
            // 
            // checkM
            // 
            this.checkM.AutoSize = true;
            this.checkM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkM.Location = new System.Drawing.Point(214, 145);
            this.checkM.Name = "checkM";
            this.checkM.Size = new System.Drawing.Size(56, 35);
            this.checkM.TabIndex = 14;
            this.checkM.Text = "M";
            this.checkM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.checkM);
            this.Controls.Add(this.checkF);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.chartSalary);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.CheckBox checkF;
        private System.Windows.Forms.CheckBox checkM;
    }
}

