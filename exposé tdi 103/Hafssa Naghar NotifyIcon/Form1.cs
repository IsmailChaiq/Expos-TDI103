using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            //notifyIcon1.BalloonTipText = "message";
            //notifyIcon1.BalloonTipTitle = "titre";
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            //notifyIcon1.Text = "poser la souris";
            //notifyIcon1.ShowBalloonTip(1000);


            notifyIcon1.Icon = SystemIcons.Application; // system

            //notifyIcon1.ShowBalloonTip ;  // la surchage 1 /2 

            notifyIcon1.ShowBalloonTip(1000, "titre 2 ", "message 2 ", ToolTipIcon.Info);
        
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            
            e.Cancel = true; // si le formulaire se ferme 
            this.Hide();

            notifyIcon1.Icon = SystemIcons.Application;

            notifyIcon1.ShowBalloonTip(1000, "ATTENTION", "APPLICATION ENCORE OUVERTE", ToolTipIcon.Warning);


        }
    }
}
