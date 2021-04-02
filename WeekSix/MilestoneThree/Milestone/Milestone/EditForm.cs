using Milestone.EmployeeData;
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
    public partial class EditForm : Form
    {
        //local connection back to previous form.
        private Form _previousForm;

        //currently selected employee to edit
        private Employee _currentEmployee;
        public Employee CurrentEmployee
        {
            get { return _currentEmployee; }
            set { _currentEmployee = value; }
        }

        public EditForm(Form previousForm)
        {
            InitializeComponent();
            _previousForm = previousForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //check for valid return to previous form.
            if(_previousForm == null)
            {
                MessageBox.Show("Could not return to previous page, Exiting!");
                System.Windows.Forms.Application.Exit();
            }
            this.Hide();
            _previousForm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ask the user if they are sure
            DialogResult result = MessageBox.Show("Overwrite old data?", "Saving new information", MessageBoxButtons.YesNo);
            if(result == DialogResult.No)
            {
                return;
            }

            //grab string fields
            _currentEmployee.EmployeeName = txtName.Text;
            _currentEmployee.EmployeePosition = txtPosition.Text;
            _currentEmployee.EmployeeDepartment = txtDepartment.Text;

            //parse new wage
            decimal wage;
            if(decimal.TryParse(txtWage.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol, null, out wage))
            {
                wage = Math.Round(wage, 2);
                _currentEmployee.EmployeeWage = wage;
            }
            else
            {
                MessageBox.Show("You must enter a valid amount for wage!");
                return;
            }
            this.Hide();
            _previousForm.Show();
        }

        public void PopulateForm()
        {
            if(_currentEmployee != null)
            {
                lblId.Text = "Employee ID: " + _currentEmployee.EmployeeId;
                txtName.Text = _currentEmployee.EmployeeName;
                txtWage.Text = _currentEmployee.EmployeeWage.ToString("C2");
                txtPosition.Text = _currentEmployee.EmployeePosition;
                txtDepartment.Text = _currentEmployee.EmployeeDepartment;
            }
        }
    }
}
