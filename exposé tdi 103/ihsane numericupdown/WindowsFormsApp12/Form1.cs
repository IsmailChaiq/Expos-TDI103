using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /* If DecimalPlaces is greater than 0, set them to 0 and round the 
            current Value; otherwise, set DecimalPlaces to 2 and change the 
            Increment to 0.25. */
            if (numericUpDown1.DecimalPlaces > 0)
            {
                numericUpDown1.DecimalPlaces = 0;
                numericUpDown1.Value = Decimal.Round(numericUpDown1.Value, 0);
            }
            else
            {
                numericUpDown1.DecimalPlaces = 2;
                numericUpDown1.Increment = 0.25M;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            /* If ThousandsSeparator is true, set it to false; 
            otherwise, set it to true. */
            if (numericUpDown1.ThousandsSeparator )
            {
                numericUpDown1.ThousandsSeparator = false;
            }
            else
            {
                numericUpDown1.ThousandsSeparator = true;
            }
        
    }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            /* If Hexadecimal is true, set it to false; 
            otherwise, set it to true. */
            if (numericUpDown1.Hexadecimal)
            {
                numericUpDown1.Hexadecimal = false;
            }
            else
            {
                numericUpDown1.Hexadecimal = true;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = 50;
            numericUpDown2.Maximum = 100;
            numericUpDown2.Minimum = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(numericUpDown2.Value.ToString());
        }
    }
}
