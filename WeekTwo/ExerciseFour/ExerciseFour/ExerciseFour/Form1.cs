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
            int minutes = 0;
            int hours = 0;
            int days = 0;

            //Hide fields
            lblDays.Hide();
            lblDaysLabel.Hide();
            lblHours.Hide();
            lblHoursLabel.Hide();
            lblMinutes.Hide();
            lblMinutesLabel.Hide();

            //try to parse seconds from the text box control
            if (int.TryParse(txtSeconds.Text, out seconds))
            {
                if(seconds < 0)
                {
                    MessageBox.Show("You must enter a non negative number for seconds!");
                    return;
                }

                //Calculate days, hours, and minutes
                days = seconds / 86400;
                hours = seconds / 3600;
                minutes = seconds / 60;
                
                //display the appropriate numbers
                if(days > 0)
                {
                    lblDays.Text = days.ToString();
                    lblDays.Show();
                    lblDaysLabel.Show();
                }
                else if(hours > 0)
                {
                    lblHours.Text = hours.ToString();
                    lblHours.Show();
                    lblHoursLabel.Show();
                }
                else if(minutes > 0)
                {
                    lblMinutes.Text = minutes.ToString();
                    lblMinutes.Show();
                    lblMinutesLabel.Show();
                }
                else
                {
                    MessageBox.Show("You must enter at least 60 seconds to convert!");
                }
            }
            else
            {
                //error trying to parse textbox
                MessageBox.Show("You must enter a valid non decimal number for the seconds!");
            }
        }
    }
}
