using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseFive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double pi = 0;
            double divisor = 1;

            //this variable is used to switch the add or subtract sign each iteration
            bool add = true;

            //reset display labels
            lblEstimate.Hide();
            lblAnswer.Hide();

            //number of terms to calculate
            int terms;
            if(!int.TryParse(txtTerms.Text, out terms))
            {
                MessageBox.Show("You must enter a valid integer for the number of terms!");
                return;
            }
            if(terms < 0)
            {
                MessageBox.Show("You must enter a positive value for terms!");
                return;
            }

            //loop to estimate pi
            for(int i = 0;i < terms;i++)
            {
                if(add)
                {
                    pi += (4 / divisor);
                }
                else
                {
                    pi -= (4 / divisor);
                }

                //setup for next iteration
                add = !add;
                divisor += 2;
            }

            //display results
            lblEstimate.Text = "Approximate value of pi after " + terms.ToString() + " term(s)";
            lblEstimate.Show();
            lblAnswer.Text = "= " + pi.ToString();
            lblAnswer.Show();
        }
    }
}
