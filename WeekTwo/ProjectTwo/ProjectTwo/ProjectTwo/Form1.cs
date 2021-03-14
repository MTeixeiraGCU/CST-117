using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset all the fields
            lbSize.SelectedIndex = 0;
            rbVanilla.Checked = true;
            foreach(CheckBox cb in gbToppings.Controls)
            {
                cb.Checked = false;
            }

            lblCost.Hide();
            lblCostLabel.Hide();
            lblIceCream.Hide();
            lblIceCreamTwo.Hide();
            lblIceCreamLabel.Hide();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            double cost = 0.0;
            string scoops = "";
            string type = "";
            string toppings = "";

            //size
            if(lbSize.SelectedItem == null)
            {
                MessageBox.Show("You must select the number of scoops first!");
                return;
            }
            scoops = lbSize.SelectedItem.ToString() + " Scoop(s)";
            cost += ((lbSize.SelectedIndex + 1) * 3.0);

            //type
            foreach(RadioButton rb in gbType.Controls)
            {
                if(rb.Checked)
                {
                    type = " of " + rb.Text + " Ice Cream";
                    break;
                }
            }

            //toppings
            bool freeTopping = true;
            foreach(CheckBox cb in gbToppings.Controls)
            {
                if (cb.Checked && freeTopping)
                {
                    freeTopping = false;
                    toppings = " with " + cb.Text;
                }
                else if(cb.Checked)
                {
                    cost += 1.90;
                    toppings += ", " + cb.Text;
                }
            }

            //display icecream type and cost
            lblIceCream.Text = scoops + type;
            lblIceCreamTwo.Text = toppings;
            lblCost.Text = cost.ToString("C");

            lblIceCream.Show();
            lblIceCreamTwo.Show();
            lblIceCreamLabel.Show();
            lblCost.Show();
            lblCostLabel.Show();
        }
    }
}
