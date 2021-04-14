using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //fill year combo box
            var years = new List<int>();
            for(int year = 1910;year < 2021;year++)
            {
                years.Add(year);
            }
            cbYear.DataSource = years;
            cbYear.SelectedIndex = 70;

            //set up month combo box
            var months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            cbMonth.DataSource = months;

            //day combo box
            SetDays(1); //initially January

            //color combo box
            var colors = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "White", "Black" };
            cbColor.DataSource = colors;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var numberForm = new NumberForm(cbYear.SelectedIndex, cbMonth.SelectedIndex, cbDay.SelectedIndex, cbColor.SelectedIndex);
            numberForm.Location = this.Location;
            numberForm.StartPosition = FormStartPosition.Manual;
            numberForm.ShowDialog();
        }

        //method for changing days combo box based on month selected.
        private void cbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            //set the days combo box by the selected index + 1 for zero based offset
            SetDays(cbMonth.SelectedIndex + 1);
        }

        //This method is designed to fill the days combo box based on the given month from 1 to 12
        private void SetDays(int month)
        {
            var days = new List<int>();
            int numberOfDays;

            //february
            if(month == 2)
            {
                numberOfDays = 29;
            }
            //months with 30 days
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                numberOfDays = 30;
            }
            //the rest are 31
            else
            {
                numberOfDays = 31;
            }

            //populate the list
            for(int day = 1; day <= numberOfDays;day++)
            {
                days.Add(day);
            }
            cbDay.DataSource = days;
        }
    }
}
