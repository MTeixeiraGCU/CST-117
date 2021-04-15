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

        public ViewForm()
        {
            InitializeComponent();

            //grab BindingList for EmployeeManager to display them graphically
            ResetDataGrid();
        }

        //resets the Data Grid View to the current list of employees
        private void ResetDataGrid()
        {
            dgvEmployees.DataSource = EmployeeManager.Instance.Employees;
            dgvEmployees.Columns["EmployeeId"].HeaderText = "Employee ID";
            dgvEmployees.Columns["EmployeeName"].HeaderText = "Name";
            dgvEmployees.Columns["EmployeeWage"].HeaderText = "Wage / Hourly";
            dgvEmployees.Columns["EmployeeWage"].DefaultCellStyle.Format = "c2";
            dgvEmployees.Columns["EmployeePosition"].HeaderText = "Position";
            dgvEmployees.Columns["EmployeeDepartment"].HeaderText = "Department";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //check if there is a single emplyoee selected
            if(dgvEmployees.SelectedRows.Count == 1)
            {
                //check with user to make sure they want to delete this employee
                DialogResult result = MessageBox.Show("Are you sure you would like to delete this employee?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //remove the employee
                    EmployeeManager.Instance.RemoveEmployee((int)dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

                    //clear the grid view
                    dgvEmployees.DataSource = null;
                    dgvEmployees.Rows.Clear();

                    //remap the datasource
                    ResetDataGrid();
                    dgvEmployees.Refresh();
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

            var editForm = new EditForm((int)dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

            //set up call back and move to new form
            editForm.Location = this.Location;
            editForm.StartPosition = FormStartPosition.Manual;
            editForm.FormClosed += delegate { this.Show(); };
            
            this.Hide();
            editForm.Show();
        }
    }
}
