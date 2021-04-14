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
    public partial class NumberForm : Form
    {
        public NumberForm(int year, int month, int day, int color)
        {
            InitializeComponent();

            //populate the label with a random number
            lblNumber.Text = GenerateLuckyNumber(year, month, day, color).ToString();
        }

        //creates a random number from 10 to 99
        private int GenerateLuckyNumber(int year, int month, int day, int color)
        {
            //offset the values to give a better spread
            year++; //can be 1-111
            month += 112; //can be 112-123
            day += 124; //can be 124-155
            color += 155; //can be 155 or greater

            Random rand = new Random(year * month * day * color);
            return rand.Next(89) + 10;
        }
    }
}
