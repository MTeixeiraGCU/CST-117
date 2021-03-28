using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseSix
{
    public partial class SidesForm : Form
    {
        //copy of main form
        TableTopForm _mainForm;

        public SidesForm(TableTopForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //attempt to grab the number from the text field
            int sides;
            if(int.TryParse(txtSides.Text, out sides))
            {
                if((sides >= 4) && (sides <= 20))
                {
                    _mainForm.ChangeDiceSides(sides);
                    this.Hide();
                    return;
                }
            }

            //else
            MessageBox.Show("You must enter a valid integer between 4 and 20 inclusive!");
        }
    }
}
