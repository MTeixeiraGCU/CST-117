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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check for at least on pattern
            if(txtName.Text == "" && txtPosition.Text == "" && txtDepartment.Text == "")
            {
                MessageBox.Show("Please enter patterns to search for!");
                return;
            }

            lblNoResults.Hide();

            //gather the different results of the search patterns
            var nameResult = EmployeeManager.Instance.SearchName(txtName.Text);
            var positionResults = EmployeeManager.Instance.SearchPosition(txtPosition.Text);
            var departmentResults = EmployeeManager.Instance.SearchDepartment(txtDepartment.Text);

            //find the intersect of all the results
            var searchResults = nameResult.Intersect(positionResults);
            searchResults = searchResults.Intersect(departmentResults);

            if(searchResults.Count<Employee>() == 0)
            {
                lblNoResults.Show();
            }

            //add them to the results area
            dgvEmployees.DataSource = searchResults.ToList<Employee>();
            dgvEmployees.Columns["EmployeeId"].HeaderText = "Employee ID";
            dgvEmployees.Columns["EmployeeName"].HeaderText = "Name";
            dgvEmployees.Columns["EmployeeWage"].HeaderText = "Wage / Hourly";
            dgvEmployees.Columns["EmployeeWage"].DefaultCellStyle.Format = "c2";
            dgvEmployees.Columns["EmployeePosition"].HeaderText = "Position";
            dgvEmployees.Columns["EmployeeDepartment"].HeaderText = "Department";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";

            lblNoResults.Hide();

            dgvEmployees.DataSource = null;
        }

        private void dgvEmployees_DoubleClick(object sender, EventArgs e)
        {
            //check for single selection
            if(dgvEmployees.SelectedRows.Count == 1)
            {
                //get the employee information
                var id = (int)dgvEmployees.SelectedRows[0].Cells["EmployeeId"].Value;
                
                //move to edit form
                var editForm = new EditForm(id);
                editForm.Location = this.Location;
                editForm.StartPosition = FormStartPosition.Manual;
                editForm.FormClosed += delegate { this.Show(); };
                this.Hide();
                editForm.Show();
                
            }
            else
            {
                MessageBox.Show("You can only select a single employee from the list!");
                return;
            }
        }
    }
}
