using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        private object txtLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime myVacation1 = new DateTime(2018, 3, 16);
            DateTime myVacation2 = new DateTime(2018, 3, 17);

            Calendrier.AddBoldedDate(myVacation1);
            Calendrier.AddBoldedDate(myVacation2);
            this.Calendrier.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.Calendrier.FirstDayOfWeek = System.Windows.Forms.Day.Tuesday;
            this.Calendrier.MaxDate = new System.DateTime(2028, 12, 31, 0, 0, 0, 0);
            this.Calendrier.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.Calendrier.MaxSelectionCount = 20;
            this.Calendrier.ShowToday = true;
            this.Calendrier.ShowTodayCircle = true;
            this.Calendrier.ShowWeekNumbers = true;

            this.Calendrier.DateSelected += new System.Windows.Forms.DateRangeEventHandler
                (this.monthCalendar1_DateSelected);


        }
        private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            //// Affiche les dates de début et de fin dans la zone de texte.
            //this.txtLabel.Text = "Date Selected :Start =" +
            //    e.Start.ToShortDateString() + ": End =" + e.End.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendrier.CalendarDimensions = new System.Drawing.Size(3, 1);
            

        }

        private void btnsemestre_Click(object sender, EventArgs e)
        {
            Calendrier.CalendarDimensions = new System.Drawing.Size(3, 2);
        }

        private void btnAnnee_Click(object sender, EventArgs e)
        {
            Calendrier.CalendarDimensions = new System.Drawing.Size(3,4);
        }

        private void btnMois_Click(object sender, EventArgs e)
        {
            Calendrier.CalendarDimensions = new System.Drawing.Size(1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
