using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GstException
{
    public partial class Form1 : Form
    {
        NotifyIcon N = new NotifyIcon();
        
        public Form1()
        {
            InitializeComponent();
            N.Visible = true;
            N.Icon = SystemIcons.Information;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Stagiaire x = new Stagiaire(txtNum.Text, txtNom.Text);
                lblInfo.Text = "Ajouté avec succès";
                N.ShowBalloonTip(1000, "Info", "Stagiaire ajouté avec succès", ToolTipIcon.Info);
            }

            catch (FormatException ex)
            {
                lblInfo.Text = ex.Message;
                txtNum.BackColor = Color.Red;
                N.ShowBalloonTip(1000, "Erreur", ex.Message, ToolTipIcon.Error);
            }

            catch (NomException ex)
            {
                lblInfo.Text = ex.Message;
                txtNom.BackColor = Color.Red;
                N.ShowBalloonTip(1000, "Erreur", ex.Message, ToolTipIcon.Error);
            }

            catch (Exception x)
            {
                lblInfo.Text = x.Message;
                N.ShowBalloonTip(1000, "Erreur", x.Message, ToolTipIcon.Error);
            }

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.BackColor == Color.Red)
            {
                txtNum.BackColor = Color.White;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.BackColor == Color.Red)
            {
                txtNom.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
