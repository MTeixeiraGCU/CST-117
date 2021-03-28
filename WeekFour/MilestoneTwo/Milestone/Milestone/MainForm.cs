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
     * <summary>Main form for the application. Lets the user decide which operations they would like to do on the employee data store.</summary>
     */
    public partial class MainForm : Form
    {
        private Form _viewForm;
        private Form _searchForm;
        private Form _addForm;

        //Data store for the collection of Employees. This will get moved into a Manager class in the next Milestone
        // TODO: Move this field into EmployeeManager class for Milestone 3
        private BindingList<Employee> _employees;
        public BindingList<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            //Mock data loaded into the Employee data store.
            _employees = new BindingList<Employee>();
            for(int index = 0;index < 10;index++)
            {
                string name = "Name " + index;
                decimal wage = 2.00m * index;
                string position = "Clerk" + index;
                string department = "Front Office";
                AddEmployee(name, wage, position, department);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if(_viewForm == null)
            {
                _viewForm = new ViewForm(this);
            }

            this.Hide();
            _viewForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_addForm == null)
            {
                _addForm = new AddForm(this);
            }

            this.Hide();
            _addForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_searchForm == null)
            {
                _searchForm = new SearchForm(this);
            }

            this.Hide();
            _searchForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
            return;
        }

        //this method will be off loaded to the Employee manager class in Milestone 3
        public void AddEmployee(string name, decimal wage, string position, string department)
        {
            _employees.Add(new Employee(name, wage, position, department));
        }
    }
}
