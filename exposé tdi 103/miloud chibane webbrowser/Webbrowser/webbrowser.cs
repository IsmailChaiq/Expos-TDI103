using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webbrowser
{
    public partial class webbrowser : Form
    {
        public webbrowser()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string webpage = txtbox.Text;
            webBrowser1.Navigate(webpage);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void webbrowser_Load(object sender, EventArgs e)
        {
            txtbox.Text = "HTTP://";
        }
    }
}
