using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseThree
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

            //grab earth weight
            double earthWeight = double.Parse(txtEarthWeight.Text);

            //generate mars weight
            double marsWeight = (earthWeight / earthGrav) * marsGrav;

            //display mars weight
            txtMarsWeight.Text = marsWeight.ToString("f");
        }
    }
}
