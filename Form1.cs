using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Exposé_TDI103;
using System.IO;
using System.Diagnostics;

namespace Exposé_TDI103
{
    public partial class frmExpose : Form
    {
        public frmExpose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            xListView.Form1 frm1 = new xListView.Form1();
            

            frm1.Text = "ListView par Hamza Filahi";
            frm1.Show();
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            ComboBox.Menu frmCmb = new ComboBox.Menu();
            frmCmb.Text = "ComboBox par Mariam ElWafi";
            frmCmb.Show();
        }

        private void btnBackgroundWorker_Click(object sender, EventArgs e)
        {
            BackgroundWorker.frmBackgroundWorker frmBackgroundWorker = new BackgroundWorker.frmBackgroundWorker();
            frmBackgroundWorker.Text = "BackgroudWorker par Ahmed Ennouri";
            frmBackgroundWorker.Show();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart_c_sharpe.Form1 frm = new Chart_c_sharpe.Form1();
            frm.Text = "Chart par Alae Jelouane";
            frm.Show();
        }

        private void btnChekedListBox_Click(object sender, EventArgs e)
        {
            checked_list_box.TP_Checked_list_box frmChk = new checked_list_box.TP_Checked_list_box();
            frmChk.Text = "CheckedListBox par Walaa Allam";
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\walaa  (overide et checkedlistbox\\OVERRIDE C#.pptx"));
            }
            frmChk.Show();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnFileSystemWatcher_Click(object sender, EventArgs e)
        {
            Filesystemwatcher.Form1 frm = new Filesystemwatcher.Form1();
            frm.Text = "FileSystemWatcher par Abdelhadi Errafii";
            frm.Show();
        }

        private void btnMaskedTextBox_Click(object sender, EventArgs e)
        {
            maskedtextbox.Form1 frm = new maskedtextbox.Form1();
            frm.Text = "MaskedTextBox par Reda Aouad";
            frm.Show();
        }

        private void btnMdiParent_Click(object sender, EventArgs e)
        {
            mdiParent3.Form1 frm1 = new mdiParent3.Form1();

            frm1.Text = "MdiParent par Oussama Saadi";

            frm1.ShowDialog();
        }

        private void btnMenuStrio_Click(object sender, EventArgs e)
        {
            MenuStrip4.Form1 frm = new MenuStrip4.Form1();
            frm.Text = "MenuStrip par Oussama Saadi";
            frm.Show();
        }

        private void btnMonthCalendar_Click(object sender, EventArgs e)
        {
            MonthCalendar.Form1 frm = new MonthCalendar.Form1();
            frm.Text = "MonthCalendar par Imad Fadil";
            frm.Show();
        }

        private void btnNotifyIcon_Click(object sender, EventArgs e)
        {
            NotifyIcon.Form1 frm = new NotifyIcon.Form1();
            frm.Text = "NotifyIcon par Hafssa Naghar";
            frm.Show();
        }

        private void btnNumericUpDown_Click(object sender, EventArgs e)
        {
            NumericUpDown.Form1 frm = new NumericUpDown.Form1();
            frm.Text = "NumericUpDown par Ihssane Sfifa";
            frm.Show();
        }

        private void btnTreeViewList_Click(object sender, EventArgs e)
        {
            TreeViewList.Form1 frm = new TreeViewList.Form1();
            TreeViewList.Form2 frm2 = new TreeViewList.Form2();

            frm.Text = "TreeViewList par Safaa Boulif";
            frm2.Text = "TreeViewList par Safaa Boulif";

            frm.ShowDialog();
            frm2.ShowDialog();
        }

        private void btnWebBrowser_Click(object sender, EventArgs e)
        {
            Webbrowser.webbrowser frm = new Webbrowser.webbrowser();
            frm.Text = "WebBrowser par Miloud Chibane";
            frm.Show();
        }

        private void btnUserControl_Click(object sender, EventArgs e)
        {
            user_control.Form1 frm = new user_control.Form1();
            user_control.Form2 frm2 = new user_control.Form2();
            user_control.Form3 frm3 = new user_control.Form3();
            user_control.Form4 frm4 = new user_control.Form4();

            frm.Text = "UserControl par Mehdi Saadi";
            frm2.Text = "UserControl par Mehdi Saadi";
            frm3.Text = "UserControl par Mehdi Saadi";
            frm4.Text = "UserControl par Mehdi Saadi";
            frm.ShowDialog();
            frm2.ShowDialog();
            frm3.ShowDialog();
            frm4.ShowDialog();
        }

        private void btnTHConsole_Click(object sender, EventArgs e)
        {
            thread2.Program.Main(new string[5]);
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\linq et thread messaoudi\\MULTI THREADING.pptx"));
            }
        }

        private void btnTHForm_Click(object sender, EventArgs e)
        {
            threadWin.Form1 frm = new threadWin.Form1();
            //threadWin.Form2 frm2 = new threadWin.Form2();
            //threadWin.Form3 frm3 = new threadWin.Form3();

            frm.Text = "Threads Formulaire par Amine Messaoudi";
            //frm2.Text = "Threads Formulaire par Amine Messaoudi";
            //frm3.Text = "Threads Formulaire par Amine Messaoudi";

            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\linq et thread messaoudi\\MULTI THREADING.pptx"));
            }
            frm.ShowDialog();

        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\Walaa OVERRIDE\\OVERRIDE C#.pptx"));
            }

        }

        private void btnColl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\collections  SihamFallah\\CourCsharpT.pptx"));
            }
        }

        private void btnLinQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\linq et thread messaoudi\\PRlinQ.pptx"));
            }
        }

        private void btnDGV_Click(object sender, EventArgs e)
        {
            datagridview.Form1 frm = new datagridview.Form1();
            frm.Text = "DataGridView par Ismail Chaiq";
            frm.Show();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ce TP dispose d'un exposé PowerPoint. Voulez-vous l'ouvrir ?", "Ouverture de l'exposé", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(Path.Combine(Application.StartupPath, "..\\..\\exposé tdi 103\\ismail chaiq dataGridView\\Presentation.pptx"));
            }
            GstException.Form1 form = new GstException.Form1();
            form.Text = "Gestion des exceptions par Ismail Chaiq";
        }
    }
}
