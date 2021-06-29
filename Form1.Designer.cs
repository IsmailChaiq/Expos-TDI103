
namespace Exposé_TDI103
{
    partial class frmExpose
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpose));
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabTool = new System.Windows.Forms.TabPage();
            this.btnWebBrowser = new System.Windows.Forms.Button();
            this.btnTreeViewList = new System.Windows.Forms.Button();
            this.btnNumericUpDown = new System.Windows.Forms.Button();
            this.btnNotifyIcon = new System.Windows.Forms.Button();
            this.btnMonthCalendar = new System.Windows.Forms.Button();
            this.btnMenuStrio = new System.Windows.Forms.Button();
            this.btnMdiParent = new System.Windows.Forms.Button();
            this.btnMaskedTextBox = new System.Windows.Forms.Button();
            this.btnFileSystemWatcher = new System.Windows.Forms.Button();
            this.btnVScrollBar = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnChekedListBox = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnBackgroundWorker = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.tabCours = new System.Windows.Forms.TabPage();
            this.btnUserControl = new System.Windows.Forms.Button();
            this.bunifuPages1.SuspendLayout();
            this.tabTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tabTool);
            this.bunifuPages1.Controls.Add(this.tabCours);
            this.bunifuPages1.ItemSize = new System.Drawing.Size(96, 36);
            this.bunifuPages1.Location = new System.Drawing.Point(-1, 0);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabTool;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "tabTool";
            this.bunifuPages1.PageTitle = "ToolBox";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(804, 449);
            this.bunifuPages1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.bunifuPages1.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabTool
            // 
            this.tabTool.Controls.Add(this.btnUserControl);
            this.tabTool.Controls.Add(this.btnWebBrowser);
            this.tabTool.Controls.Add(this.btnTreeViewList);
            this.tabTool.Controls.Add(this.btnNumericUpDown);
            this.tabTool.Controls.Add(this.btnNotifyIcon);
            this.tabTool.Controls.Add(this.btnMonthCalendar);
            this.tabTool.Controls.Add(this.btnMenuStrio);
            this.tabTool.Controls.Add(this.btnMdiParent);
            this.tabTool.Controls.Add(this.btnMaskedTextBox);
            this.tabTool.Controls.Add(this.btnFileSystemWatcher);
            this.tabTool.Controls.Add(this.btnVScrollBar);
            this.tabTool.Controls.Add(this.btnTimer);
            this.tabTool.Controls.Add(this.btnChekedListBox);
            this.tabTool.Controls.Add(this.btnChart);
            this.tabTool.Controls.Add(this.btnBackgroundWorker);
            this.tabTool.Controls.Add(this.btnComboBox);
            this.tabTool.Controls.Add(this.btnListView);
            this.tabTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTool.Location = new System.Drawing.Point(4, 4);
            this.tabTool.Name = "tabTool";
            this.tabTool.Padding = new System.Windows.Forms.Padding(3);
            this.tabTool.Size = new System.Drawing.Size(796, 405);
            this.tabTool.TabIndex = 0;
            this.tabTool.Text = "ToolBox";
            this.tabTool.UseVisualStyleBackColor = true;
            // 
            // btnWebBrowser
            // 
            this.btnWebBrowser.Location = new System.Drawing.Point(695, 85);
            this.btnWebBrowser.Name = "btnWebBrowser";
            this.btnWebBrowser.Size = new System.Drawing.Size(92, 73);
            this.btnWebBrowser.TabIndex = 15;
            this.btnWebBrowser.Text = "WebBrowser\r\n\rMiloud Chibane";
            this.btnWebBrowser.UseVisualStyleBackColor = true;
            this.btnWebBrowser.Click += new System.EventHandler(this.btnWebBrowser_Click);
            // 
            // btnTreeViewList
            // 
            this.btnTreeViewList.Location = new System.Drawing.Point(597, 85);
            this.btnTreeViewList.Name = "btnTreeViewList";
            this.btnTreeViewList.Size = new System.Drawing.Size(92, 73);
            this.btnTreeViewList.TabIndex = 14;
            this.btnTreeViewList.Text = "TreeViewList\r\n\r\nSafaa Boulif";
            this.btnTreeViewList.UseVisualStyleBackColor = true;
            this.btnTreeViewList.Click += new System.EventHandler(this.btnTreeViewList_Click);
            // 
            // btnNumericUpDown
            // 
            this.btnNumericUpDown.Location = new System.Drawing.Point(499, 85);
            this.btnNumericUpDown.Name = "btnNumericUpDown";
            this.btnNumericUpDown.Size = new System.Drawing.Size(92, 73);
            this.btnNumericUpDown.TabIndex = 13;
            this.btnNumericUpDown.Text = "Numeric UpDown\r\n\r\nIhssane Sfifa\r\n";
            this.btnNumericUpDown.UseVisualStyleBackColor = true;
            this.btnNumericUpDown.Click += new System.EventHandler(this.btnNumericUpDown_Click);
            // 
            // btnNotifyIcon
            // 
            this.btnNotifyIcon.Location = new System.Drawing.Point(401, 85);
            this.btnNotifyIcon.Name = "btnNotifyIcon";
            this.btnNotifyIcon.Size = new System.Drawing.Size(92, 73);
            this.btnNotifyIcon.TabIndex = 12;
            this.btnNotifyIcon.Text = "NotifyIcon\r\n\r\nHafssa Naghar";
            this.btnNotifyIcon.UseVisualStyleBackColor = true;
            this.btnNotifyIcon.Click += new System.EventHandler(this.btnNotifyIcon_Click);
            // 
            // btnMonthCalendar
            // 
            this.btnMonthCalendar.Location = new System.Drawing.Point(303, 85);
            this.btnMonthCalendar.Name = "btnMonthCalendar";
            this.btnMonthCalendar.Size = new System.Drawing.Size(92, 73);
            this.btnMonthCalendar.TabIndex = 11;
            this.btnMonthCalendar.Text = "\r\nMonthCalendar \r\n\r\nImad Fadil\r\n\r\n";
            this.btnMonthCalendar.UseVisualStyleBackColor = true;
            this.btnMonthCalendar.Click += new System.EventHandler(this.btnMonthCalendar_Click);
            // 
            // btnMenuStrio
            // 
            this.btnMenuStrio.Location = new System.Drawing.Point(205, 85);
            this.btnMenuStrio.Name = "btnMenuStrio";
            this.btnMenuStrio.Size = new System.Drawing.Size(92, 73);
            this.btnMenuStrio.TabIndex = 10;
            this.btnMenuStrio.Text = "\r\nMenuStrip\r\n\r\nOussama Saadi\r\n\r\n\r\n";
            this.btnMenuStrio.UseVisualStyleBackColor = true;
            this.btnMenuStrio.Click += new System.EventHandler(this.btnMenuStrio_Click);
            // 
            // btnMdiParent
            // 
            this.btnMdiParent.Location = new System.Drawing.Point(107, 85);
            this.btnMdiParent.Name = "btnMdiParent";
            this.btnMdiParent.Size = new System.Drawing.Size(92, 73);
            this.btnMdiParent.TabIndex = 9;
            this.btnMdiParent.Text = "MdiParent\r\n\r\n Oussama Saadi\r\n";
            this.btnMdiParent.UseVisualStyleBackColor = true;
            this.btnMdiParent.Click += new System.EventHandler(this.btnMdiParent_Click);
            // 
            // btnMaskedTextBox
            // 
            this.btnMaskedTextBox.Location = new System.Drawing.Point(9, 85);
            this.btnMaskedTextBox.Name = "btnMaskedTextBox";
            this.btnMaskedTextBox.Size = new System.Drawing.Size(92, 73);
            this.btnMaskedTextBox.TabIndex = 8;
            this.btnMaskedTextBox.Text = "MaskedTextBox\r\n\r\nReda Aouad";
            this.btnMaskedTextBox.UseVisualStyleBackColor = true;
            this.btnMaskedTextBox.Click += new System.EventHandler(this.btnMaskedTextBox_Click);
            // 
            // btnFileSystemWatcher
            // 
            this.btnFileSystemWatcher.Location = new System.Drawing.Point(695, 6);
            this.btnFileSystemWatcher.Name = "btnFileSystemWatcher";
            this.btnFileSystemWatcher.Size = new System.Drawing.Size(92, 73);
            this.btnFileSystemWatcher.TabIndex = 7;
            this.btnFileSystemWatcher.Text = "FileSystem Watcher\r\nAbdelhadi Errafii\r\n";
            this.btnFileSystemWatcher.UseVisualStyleBackColor = true;
            this.btnFileSystemWatcher.Click += new System.EventHandler(this.btnFileSystemWatcher_Click);
            // 
            // btnVScrollBar
            // 
            this.btnVScrollBar.Location = new System.Drawing.Point(597, 6);
            this.btnVScrollBar.Name = "btnVScrollBar";
            this.btnVScrollBar.Size = new System.Drawing.Size(92, 73);
            this.btnVScrollBar.TabIndex = 6;
            this.btnVScrollBar.Text = " VScrollBar\r\n\r\nMehdi Lotfy\r\n";
            this.btnVScrollBar.UseVisualStyleBackColor = true;
            this.btnVScrollBar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(499, 6);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(92, 73);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "Timer\r\n\r\nRachid Katim";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnChekedListBox
            // 
            this.btnChekedListBox.Location = new System.Drawing.Point(401, 6);
            this.btnChekedListBox.Name = "btnChekedListBox";
            this.btnChekedListBox.Size = new System.Drawing.Size(92, 73);
            this.btnChekedListBox.TabIndex = 4;
            this.btnChekedListBox.Text = "Checked List Box\r\n\r\nWalaa Allam\r\n";
            this.btnChekedListBox.UseVisualStyleBackColor = true;
            this.btnChekedListBox.Click += new System.EventHandler(this.btnChekedListBox_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(303, 6);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(92, 73);
            this.btnChart.TabIndex = 3;
            this.btnChart.Text = "Chart \r\n\r\nAlae Jelouane\r\n";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnBackgroundWorker
            // 
            this.btnBackgroundWorker.Location = new System.Drawing.Point(205, 6);
            this.btnBackgroundWorker.Name = "btnBackgroundWorker";
            this.btnBackgroundWorker.Size = new System.Drawing.Size(92, 73);
            this.btnBackgroundWorker.TabIndex = 2;
            this.btnBackgroundWorker.Text = "Background\r\nWorker\r\n\r\nAhmed Ennouri\r\n\r\n";
            this.btnBackgroundWorker.UseVisualStyleBackColor = true;
            this.btnBackgroundWorker.Click += new System.EventHandler(this.btnBackgroundWorker_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(107, 6);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(92, 73);
            this.btnComboBox.TabIndex = 1;
            this.btnComboBox.Text = "ComboBox\r\n\r\nMariam ElWafi\r\n";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // btnListView
            // 
            this.btnListView.Location = new System.Drawing.Point(9, 6);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(92, 73);
            this.btnListView.TabIndex = 0;
            this.btnListView.Text = "ListView\r\n\r\nHamza Filahi";
            this.btnListView.UseVisualStyleBackColor = true;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // tabCours
            // 
            this.tabCours.Location = new System.Drawing.Point(4, 4);
            this.tabCours.Name = "tabCours";
            this.tabCours.Padding = new System.Windows.Forms.Padding(3);
            this.tabCours.Size = new System.Drawing.Size(796, 405);
            this.tabCours.TabIndex = 1;
            this.tabCours.Text = "Cours C#";
            this.tabCours.UseVisualStyleBackColor = true;
            // 
            // btnUserControl
            // 
            this.btnUserControl.Location = new System.Drawing.Point(303, 164);
            this.btnUserControl.Name = "btnUserControl";
            this.btnUserControl.Size = new System.Drawing.Size(92, 73);
            this.btnUserControl.TabIndex = 16;
            this.btnUserControl.Text = "UserControl\r\n\r\nMehdi Saadi";
            this.btnUserControl.UseVisualStyleBackColor = true;
            this.btnUserControl.Click += new System.EventHandler(this.btnUserControl_Click);
            // 
            // frmExpose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuPages1);
            this.Name = "frmExpose";
            this.Text = "Exposé TDI103";
            this.bunifuPages1.ResumeLayout(false);
            this.tabTool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabTool;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.TabPage tabCours;
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnWebBrowser;
        private System.Windows.Forms.Button btnTreeViewList;
        private System.Windows.Forms.Button btnNumericUpDown;
        private System.Windows.Forms.Button btnNotifyIcon;
        private System.Windows.Forms.Button btnMonthCalendar;
        private System.Windows.Forms.Button btnMenuStrio;
        private System.Windows.Forms.Button btnMdiParent;
        private System.Windows.Forms.Button btnMaskedTextBox;
        private System.Windows.Forms.Button btnFileSystemWatcher;
        private System.Windows.Forms.Button btnVScrollBar;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnChekedListBox;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnBackgroundWorker;
        private System.Windows.Forms.Button btnUserControl;
    }
}

