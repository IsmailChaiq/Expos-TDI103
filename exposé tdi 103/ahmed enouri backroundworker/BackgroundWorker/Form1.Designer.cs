
namespace BackgroundWorker
{
    partial class frmBackgroundWorker
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblcounter = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bgworker2 = new System.ComponentModel.BackgroundWorker();
            this.lblisworking = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(183, 67);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblcounter
            // 
            this.lblcounter.AutoSize = true;
            this.lblcounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcounter.Location = new System.Drawing.Point(490, 43);
            this.lblcounter.Name = "lblcounter";
            this.lblcounter.Size = new System.Drawing.Size(29, 18);
            this.lblcounter.TabIndex = 3;
            this.lblcounter.Text = "0%";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(89, 43);
            this.progressBar.Maximum = 10000;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(395, 18);
            this.progressBar.TabIndex = 5;
            // 
            // bgworker2
            // 
            this.bgworker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgworker2_DoWork);
            // 
            // lblisworking
            // 
            this.lblisworking.AutoSize = true;
            this.lblisworking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisworking.Location = new System.Drawing.Point(219, 96);
            this.lblisworking.Name = "lblisworking";
            this.lblisworking.Size = new System.Drawing.Size(0, 18);
            this.lblisworking.TabIndex = 6;
            // 
            // lblStop
            // 
            this.lblStop.Location = new System.Drawing.Point(325, 67);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(75, 23);
            this.lblStop.TabIndex = 7;
            this.lblStop.Text = "Stop";
            this.lblStop.UseVisualStyleBackColor = true;
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // frmBackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 142);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lblisworking);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblcounter);
            this.Controls.Add(this.btnStart);
            this.Name = "frmBackgroundWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblcounter;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker bgworker2;
        private System.Windows.Forms.Label lblisworking;
        private System.Windows.Forms.Button lblStop;
    }
}

