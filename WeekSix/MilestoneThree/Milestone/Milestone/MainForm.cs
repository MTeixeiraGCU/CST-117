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
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var viewForm = new ViewForm();

            //set new form with location and call back method
            viewForm.Location = this.Location;
            viewForm.StartPosition = FormStartPosition.Manual;
            viewForm.FormClosed += delegate { this.Show(); };
            
            this.Hide();
            viewForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();

            //set new form with location and call back method
            addForm.Location = this.Location;
            addForm.StartPosition = FormStartPosition.Manual;
            addForm.FormClosed += delegate { this.Show(); };

            this.Hide();
            addForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm();

            //set new form with location and call back method
            searchForm.Location = this.Location;
            searchForm.StartPosition = FormStartPosition.Manual;
            searchForm.FormClosed += delegate { this.Show(); };

            this.Hide();
            searchForm.Show();
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
    }
}
