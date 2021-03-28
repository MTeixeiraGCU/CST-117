using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseSix
{
    public partial class TableTopForm : Form
    {
        //These fields represent the two dice being rolled
        private Dice _dieOne;
        private Dice _dieTwo;

        //counter for tracking dice rolls
        private int _numberOfRolls;

        //this is the form to ask the user to enter a different number of sides
        private SidesForm sidesForm;

        public TableTopForm()
        {
            InitializeComponent();
            ChangeDiceSides(4);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if(RollDice())
            {
                //display results of snake eyes
                SnakeEyes();
            }
        }

        //This method takes in a number of sides and switches the dice to match
        public void ChangeDiceSides(int sides)
        {
            _dieOne = new Dice(sides);
            _dieTwo = new Dice(sides);
            lblSides.Text = "Rolling d" + sides + "s!";

            //reset dice rolls
            _numberOfRolls = 0;
        }

        private void btnChangeSides_Click(object sender, EventArgs e)
        {
            //check for valid sides form
            if (sidesForm == null)
            {
                sidesForm = new SidesForm(this);
            }
            sidesForm.Show();
        }

        private void btnRollSnakeEyes_Click(object sender, EventArgs e)
        {
            //loop until we achieve snake eyes
            while (!RollDice()) ;

            //display results of snake eyes
            SnakeEyes();
            
        }

        //roll the dice a single time
        private bool RollDice()
        {
            //set up a die roll
            int firstDie = _dieOne.rollDie();
            int secondDie = _dieTwo.rollDie();
            lblDieOne.Text = firstDie.ToString();
            lblDieTwo.Text = secondDie.ToString();
            _numberOfRolls++;

            //display results
            Console.WriteLine(firstDie + ", " + secondDie + " " + _numberOfRolls + " Rolls so far!");

            //check for snake eyes
            if(firstDie == 1 && secondDie == 1)
            {
                return true;
            }
            return false;
        }

        //notify snakes eyes
        private void SnakeEyes()
        {
            string message = "It took " + _numberOfRolls + " roll(s) to achieve snake eyes! Would you like to continue?"; 
            DialogResult results = MessageBox.Show(message, "Snake Eyes!", MessageBoxButtons.YesNo);
            if (results == DialogResult.No)
            {
                System.Windows.Forms.Application.Exit();
            }

            //continue from 0
            _numberOfRolls = 0;
        }
    }
}
