using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //setup intial value
            int seconds = 0;

            //try to parse seconds from the text box control
            try
            {
                seconds = int.Parse(txtSeconds.Text);
                if(seconds < 0)
                {
                    throw new FormatException();
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("You must enter a value for seconds!");
                Console.WriteLine("No data recieved, " + ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("You must enter a valid non decimal non negative number for the seconds!");
                Console.WriteLine("Invalid number, " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must enter a valid number for the seconds!");
                Console.WriteLine(ex.Message);
            }

            //Calculate minutes, hours, and days
            MinutesFromSeconds(seconds);
            HoursFromSeconds(seconds);
            DaysFromSeconds(seconds);
        }

        /**
         * This method takes in the number of seconds and populates or hides the minutes control.
         */
        private void MinutesFromSeconds(int seconds)
        {
            int minutes = seconds / 60;
            if (minutes > 0)
            {
                lblMinutes.Text = minutes.ToString();
                lblMinutes.Show();
                lblMinutesLabel.Show();
            }
            else
            {
                lblMinutes.Hide();
                lblMinutesLabel.Hide();
            }
        }

        /**
         * This method takes in the number of seconds and populates or hides the hours control.
         */
        private void HoursFromSeconds(int seconds)
        {
            int hours = seconds / 3600;
            if(hours > 0)
            {
                lblHours.Text = hours.ToString();
                lblHours.Show();
                lblHoursLabel.Show();
            }
            else
            {
                lblHours.Hide();
                lblHoursLabel.Hide();
            }
        }

        /**
         * This method takes in the number of seconds and populates or hides the days control.
         */
        private void DaysFromSeconds(int seconds)
        {
            int days = seconds / 86400;
            if(days > 0)
            {
                lblDays.Text = days.ToString();
                lblDays.Show();
                lblDaysLabel.Show();
            }
            else
            {
                lblDays.Hide();
                lblDaysLabel.Hide();
            }
        }
    }
}
