using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class frmBackgroundWorker : Form
    {
        public frmBackgroundWorker()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblisworking.Text="is working counter ...";
            if(bgWorker.IsBusy)
            {
                bgworker2.RunWorkerAsync();
            }
            else { bgWorker.RunWorkerAsync(); }
           
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int counter = 0; counter <= 10000; counter++)
            {

                lblcounter.Invoke((MethodInvoker)delegate { lblcounter.Text =counter + "%".ToString(); });
                bgWorker.ReportProgress(counter);
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblisworking.Text= "Completed Counter";
            MessageBox.Show("has been is completed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Application.Exit();
        }

        private void bgworker2_DoWork(object sender, DoWorkEventArgs e)
        {
             MessageBox.Show("wait is working ......", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
