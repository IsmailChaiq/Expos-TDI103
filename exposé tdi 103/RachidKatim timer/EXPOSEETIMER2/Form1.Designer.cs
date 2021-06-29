
namespace EXPOSEETIMER2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPointDepart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtMseconds = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(66, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 42);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPointDepart
            // 
            this.btnPointDepart.BackColor = System.Drawing.Color.Black;
            this.btnPointDepart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPointDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPointDepart.Location = new System.Drawing.Point(306, 150);
            this.btnPointDepart.Name = "btnPointDepart";
            this.btnPointDepart.Size = new System.Drawing.Size(168, 42);
            this.btnPointDepart.TabIndex = 4;
            this.btnPointDepart.Text = "Point Depart";
            this.btnPointDepart.UseVisualStyleBackColor = false;
            this.btnPointDepart.Click += new System.EventHandler(this.btnPointDepart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Black;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStop.Location = new System.Drawing.Point(182, 150);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 42);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.Color.Black;
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMinutes.ForeColor = System.Drawing.Color.Lime;
            this.txtMinutes.Location = new System.Drawing.Point(119, 61);
            this.txtMinutes.Multiline = true;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(61, 39);
            this.txtMinutes.TabIndex = 6;
            this.txtMinutes.Text = "00";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMseconds
            // 
            this.txtMseconds.BackColor = System.Drawing.Color.Black;
            this.txtMseconds.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMseconds.ForeColor = System.Drawing.Color.Lime;
            this.txtMseconds.Location = new System.Drawing.Point(287, 61);
            this.txtMseconds.Multiline = true;
            this.txtMseconds.Name = "txtMseconds";
            this.txtMseconds.Size = new System.Drawing.Size(61, 39);
            this.txtMseconds.TabIndex = 7;
            this.txtMseconds.Text = "00";
            this.txtMseconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSecond
            // 
            this.txtSecond.BackColor = System.Drawing.Color.Black;
            this.txtSecond.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSecond.ForeColor = System.Drawing.Color.Lime;
            this.txtSecond.Location = new System.Drawing.Point(203, 61);
            this.txtSecond.Multiline = true;
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(61, 39);
            this.txtSecond.TabIndex = 8;
            this.txtSecond.Text = "00";
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(541, 270);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtMseconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPointDepart);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPointDepart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtMseconds;
        private System.Windows.Forms.TextBox txtSecond;
    }
}

