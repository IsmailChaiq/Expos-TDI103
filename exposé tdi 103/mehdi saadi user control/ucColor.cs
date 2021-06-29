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
    public partial class ucColor : UserControl
    {
        public ucColor()
        {
            InitializeComponent();
        }


        private Color _controlcolor;



        public Color ControlColor
        {
            get { return _controlcolor; }
            set { _controlcolor = value; }
        }








        public event EventHandler ColourChange ;  
        protected virtual void  OnColorChanged(EventArgs e)
        {
            ColourChange?.Invoke(this, e); 
        }





        





        private void tb_Scroll(object sender, EventArgs e)
        {
            int rouge = tbRouge.Value;
            int vert = tbVert.Value;
            int bleu = tbBleu.Value;
            Color controlColor = Color.FromArgb(rouge, vert, bleu);

            try
            {
                pnlColor.BackColor = controlColor;
                _controlcolor = controlColor;
                OnColorChanged(EventArgs.Empty);


            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }




      
    }
}
