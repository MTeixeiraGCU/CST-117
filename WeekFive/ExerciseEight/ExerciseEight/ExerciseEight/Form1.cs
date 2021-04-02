using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseEight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calculates the number of calories from the given grams of fat
        private double FatCalories(double fatGrams)
        {
            return fatGrams * 9.0;
        }

        //calculates the number of calories from the given grams of carbohydrates
        private double CarbCalories(double carbGrames)
        {
            return carbGrames * 4.0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fatGrams;
            double carbGrams;

            //attempt to parse data from text boxes
            if(!double.TryParse(txtFatGrams.Text, out fatGrams) || fatGrams < 0.0)
            {
                MessageBox.Show("You must enter valid numbers for fat grams!");
                return;
            }
            if(!double.TryParse(txtCarbGrams.Text, out carbGrams) || carbGrams < 0.0)
            {
                MessageBox.Show("You must enter valid numbers for carb grams!");
                return;
            }

            //calculate calories with method calls
            lblFatCalories.Text = string.Format("{0} calories from fat.", FatCalories(fatGrams));
            lblCarbCalories.Text = string.Format("{0} calories from carbohydrates.", CarbCalories(carbGrams));
        }
    }
}
