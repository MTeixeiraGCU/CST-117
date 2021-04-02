using Milestone.EmployeeData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    /**
     * <summary>This form is designed to be able to view the entire emplyee list
     *          It also allows for rmeoving and editing the selected emplyee.</summary>
     */
    public partial class ViewForm : Form
    {
        //local connection to the main form.
        private readonly MainForm _mainForm;
        //sub form for editing employees
        private EditForm _editForm;

        public ViewForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            //datacource, headers, and formats for list view of employees
            dgvEmployees.DataSource = _mainForm.Employees;
            dgvEmployees.Columns["EmployeeId"].HeaderText = "Employee ID";
            dgvEmployees.Columns["EmployeeName"].HeaderText = "Name";
            dgvEmployees.Columns["EmployeeWage"].HeaderText = "Wage / Hourly";
            dgvEmployees.Columns["EmployeeWage"].DefaultCellStyle.Format = "c2";
            dgvEmployees.Columns["EmployeePosition"].HeaderText = "Position";
            dgvEmployees.Columns["EmployeeDepartment"].HeaderText = "Department";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //check for valid main form before attempting to return.
            if(_mainForm == null)
            {
                MessageBox.Show("Could not return to main menu, Exiting!");
            }
            this.Hide();
            _mainForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //check if there is a single emplyee selected
            if(dgvEmployees.SelectedRows.Count == 1)
            {
                //check with user to make sure they want to delete this employee
                DialogResult result = MessageBox.Show("Are you sure you would like to delete this employee?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //remove the employee
                    dgvEmployees.Rows.Remove(dgvEmployees.SelectedRows[0]);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //check for a selected employee
            if(dgvEmployees.SelectedRows.Count != 1)
            {
                MessageBox.Show("You must select an employee to edit first!");
                return;
            }
            //check for first time through edit form
            if(_editForm == null)
            {
                _editForm = new EditForm(this);
            }

            //get the selected employee
            _editForm.CurrentEmployee = (Employee)dgvEmployees.SelectedRows[0].DataBoundItem;
            _editForm.PopulateForm();

            this.Hide();
            _editForm.Show();
        }
    }
}
