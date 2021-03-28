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
        private readonly Form _mainForm;

        public SearchForm(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_mainForm == null)
            {
                MessageBox.Show("Could not return to main menu, Exiting!");
            }
            this.Hide();
            _mainForm.Show();
        }
    }
}
