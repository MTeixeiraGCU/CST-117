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
        //currently selected employee to edit
        private readonly int _employeeId;
        private string _employeeName;
        private decimal _employeeWage;
        private string _employeePosition;
        private string _employeeDepartment;

        public EditForm(int id)
        {
            InitializeComponent();

            //initialize values
            _employeeId = id;
            _employeeName = "";
            _employeeWage = 0.00m;
            _employeePosition = "";
            _employeeDepartment = "";

            //get the values from the manager and enter them into the form
            GetEmployeeData();
            PopulateForm();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GetEmployeeData();
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
            _employeeName = txtName.Text;
            _employeePosition = txtPosition.Text;
            _employeeDepartment = txtDepartment.Text;

            //parse new wage
            decimal wage;
            if(decimal.TryParse(txtWage.Text, NumberStyles.AllowThousands | NumberStyles.AllowDecimalPoint | NumberStyles.AllowCurrencySymbol, null, out wage))
            {
                wage = Math.Round(wage, 2);
                _employeeWage = wage;
            }
            else
            {
                MessageBox.Show("You must enter a valid amount for wage!");
                return;
            }

            //update the employee in the Employee manager
            if(!EmployeeManager.Instance.UpdateEmployee(_employeeId, _employeeName, _employeeWage, _employeePosition, _employeeDepartment))
            {
                MessageBox.Show(string.Format("Could not update employee with ID: {0}!", _employeeId));
                return;
            }

            MessageBox.Show("Employee data has been changed!");
            this.Close();
        }

        private void GetEmployeeData()
        {
            Employee employee = EmployeeManager.Instance.Get(_employeeId);
            if(employee == null)
            {
                throw new NullReferenceException(string.Format("Employee with ID: {0} not found!", _employeeId));
            }

            _employeeName = employee.EmployeeName;
            _employeeWage = employee.EmployeeWage;
            _employeePosition = employee.EmployeePosition;
            _employeeDepartment = employee.EmployeeDepartment;
        }

        private void PopulateForm()
        {
            lblId.Text = "Employee ID: " + _employeeId;
            txtName.Text = _employeeName;
            txtWage.Text = _employeeWage.ToString("C2");
            txtPosition.Text = _employeePosition;
            txtDepartment.Text = _employeeDepartment;
        }
    }
}
