using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    /**
     * <summary>This form is used for adding new employees to the list.</summary>
     */
    public partial class AddForm : Form
    {
        //local connection to the main form.
        private readonly MainForm _mainForm;

        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //check for valid main form before attempting to return
            if (_mainForm == null)
            {
                MessageBox.Show("Could not return to main menu, Exiting!");
                System.Windows.Forms.Application.Exit();
            }
            this.Hide();
            _mainForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //grab string fields
            string name = txtName.Text;
            string position = txtPosition.Text;
            string department = txtDepartment.Text;

            //parse new wage
            decimal wage;
            if (decimal.TryParse(txtWage.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol, null, out wage))
            {
                wage = Math.Round(wage, 2);
            }
            else
            {
                MessageBox.Show("You must enter a valid amount for wage!");
                return;
            }
            _mainForm.AddEmployee(name, wage, position, department);

            MessageBox.Show("New employee added!");
            this.Hide();
            _mainForm.Show();
        }
    }
}
