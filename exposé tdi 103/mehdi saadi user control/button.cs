using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_control
{
    public partial class button : UserControl
    {
        public button()
        {
            InitializeComponent();
        }


        public event EventHandler btnOnclick;


        protected virtual void OnClick(EventArgs e)
        {
            btnOnclick.Invoke(this, e);
            
          
        }

        public void btnAjouter_Click(object sender, EventArgs e)
        {
           OnClick(EventArgs.Empty);
        }

     
    }
}
