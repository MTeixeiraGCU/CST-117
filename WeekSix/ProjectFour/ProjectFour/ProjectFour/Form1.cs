using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFour
{
    public partial class Form1 : Form
    {
        //variable for random number generation
        private Random rand;

        public Form1()
        {
            InitializeComponent();
            //seed the number generator
            rand = new Random();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //array to hold game board info
            int[,] turnArray = new int[3, 3];
            ResetGameBoard(turnArray);

            //flag to indicate if there was a winner
            bool winner = false;

            //number of turns so far
            int numberOfTurns = 0;

            //fill the two dimensional turn array with randow entries
            for (int row = 0; row < turnArray.GetLength(0); row++)
            {
                for (int column = 0; column < turnArray.GetLength(1); column++)
                {
                    turnArray[row, column] = rand.Next(2);
                    numberOfTurns++;

                    //check for a winner
                    if (FindWinner(turnArray))
                    {
                        winner = true;
                        
                        //end both loops
                        row = turnArray.GetLength(0);
                        column = turnArray.GetLength(1);
                        break;
                    }
                }
            }

            //check if there was a tie result
            if(!winner)
            {
                lbWinner.Text = "Tie!";
            }

            //Draw the new game board
            PrintGameBoard(turnArray);
        }

        /**
         * emptys the game board
         */
        private void ResetGameBoard(int[,] turnArray)
        {
            lbWinner.Text = "";
            int positionIndex = 0;
            foreach (Control gameSquare in gbGameBoard.Controls)
            {
                gameSquare.Text = "";
                turnArray[positionIndex / turnArray.GetLength(0), positionIndex % turnArray.GetLength(1)] = -1;
                positionIndex++;
            }
        }

        /**
         * goes through each column, row, and diagonal looking for a winner.
         * limitiations: this method can only check a 3x3 collection
         */
        private bool FindWinner(int[,] turnArray)
        {
            //check all three rows
            for (int row = 0; row < turnArray.GetLength(0); row++)
            {
                if (turnArray[row, 0] == 0 && turnArray[row, 1] == 0 && turnArray[row, 2] == 0)
                {
                    lbWinner.Text = "O Wins!";
                    return true;
                }
                else if (turnArray[row, 0] == 1 && turnArray[row, 1] == 1 && turnArray[row, 2] == 1)
                {
                    lbWinner.Text = "X Wins!";
                    return true;
                }
            }

            //check all three columns
            for (int column = 0; column < turnArray.GetLength(1); column++)
            {
                if (turnArray[0, column] == 0 && turnArray[1, column] == 0 && turnArray[2, column] == 0)
                {
                    lbWinner.Text = "O Wins!";
                    return true;
                }
                else if (turnArray[0, column] == 1 && turnArray[1, column] == 1 && turnArray[2, column] == 1)
                {
                    lbWinner.Text = "X Wins!";
                    return true;
                }
            }

            //check diagonal top-left to bottom right
            if (turnArray[0, 0] == 0 && turnArray[1, 1] == 0 && turnArray[2, 2] == 0)
            {
                lbWinner.Text = "O Wins!";
                return true;
            }
            else if (turnArray[0, 0] == 1 && turnArray[1, 1] == 1 && turnArray[2, 2] == 1)
            {
                lbWinner.Text = "X Wins!";
                return true;
            }

            //check for diagonal top-right to bottom-left
            if(turnArray[0, 2] == 0 && turnArray[1, 1] == 0 && turnArray[2, 0] == 0)
            {
                lbWinner.Text = "O Wins!";
                return true;
            }
            else if(turnArray[0, 2] == 1 && turnArray[1, 1] == 1 && turnArray[2, 0] == 1)
            {
                lbWinner.Text = "X Wins!";
                return true;
            }

            return false;
        }

        /**
         * prints the game board from a given two dimensional array
         */
        private void PrintGameBoard(int[,] turnArray)
        {
            int positionIndex = 0;

            //loop through each label in the group box
            foreach(Control control in gbGameBoard.Controls)
            {
                if (turnArray[positionIndex / turnArray.GetLength(0), positionIndex % turnArray.GetLength(1)] >= 0)
                {
                    //either X or O turn in this cell
                    control.Text = turnArray[positionIndex / turnArray.GetLength(0), positionIndex % turnArray.GetLength(1)] == 0 ? "O" : "X";
                }
                else
                {
                    //empty cell
                    control.Text = "";
                }
                positionIndex++;
            }
        }
    }
}
