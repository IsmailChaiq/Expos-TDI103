using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdiParent3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            bool t = false;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == "Form2")
                    t = true;
            }
            if (t == false)
            {
                Form2 f = new Form2();
                f.Name = "Form2";
                f.MdiParent = this;
                f.Show();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            
        }
    }
}
