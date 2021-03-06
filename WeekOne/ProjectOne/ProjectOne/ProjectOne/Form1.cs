using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double earthGrav = 9.81;
            double marsGrav = 3.711;
            double earthWeight = 0.0;

            //try block for parsing the earth weight
            try
            {
                //grab earth weight
                earthWeight = double.Parse(txtEarthWeight.Text);

                //check for negative weight
                if (earthWeight < 0.0)
                {
                    MessageBox.Show("You must enter a positive weight!");
                    resetTextFields();
                }
                else
                {
                    //generate mars weight
                    double marsWeight = (earthWeight / earthGrav) * marsGrav;

                    //display mars weight
                    txtMarsWeight.Text = marsWeight.ToString("n3");
                }
            }
            catch
            {
                MessageBox.Show("You need to enter a number in for the Earth Weight!");
                resetTextFields();
            }
        }

        private void resetTextFields()
        {
            txtEarthWeight.Text = "0.000";
            txtMarsWeight.Text = "0.000";
        }
    }
}
