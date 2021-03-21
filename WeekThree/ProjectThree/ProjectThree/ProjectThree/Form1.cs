using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {

            StreamReader inputFile;
            string firstAlpha = "";
            string lastAlpha = "";
            string longestWord = "";
            string mostVowels = "";
            int mostVowelsCount = 0;

            //hide displays
            lblFile.Hide();
            lblAlphaFirst.Hide();
            lblAlphaLast.Hide();
            lblLongest.Hide();
            lblMostVowels.Hide();

            //ask the user to select a file
            if(openFile.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Please select an appropriate text file!");
                return;
            }

            //try to open the selected file
            try
            {
                //open file
                inputFile = File.OpenText(openFile.FileName);
                lblFile.Text = "Showing results for " + openFile.SafeFileName;

                //loop through the file input stream
                while (!inputFile.EndOfStream)
                {
                    //grab a row, convert to lowercase, and split it into words
                    string[] words = inputFile.ReadLine().ToLower().Split(' ');

                    //loop through each word on the line
                    foreach (string word in words)
                    {
                        //remove punctuation and check for null
                        string newWord = Regex.Replace(word, "[.,?!:;]", "");
                        if(newWord == "")
                        {
                            continue;
                        }

                        //check first alphbetically
                        if (firstAlpha == "" || string.Compare(firstAlpha, newWord) > 0)
                        {
                            firstAlpha = newWord;
                        }
                        
                        //check last alphabetically
                        if (lastAlpha == "" || string.Compare(lastAlpha, newWord) < 0)
                        {
                            lastAlpha = newWord;
                        }

                        //check longest word
                        if (longestWord == "" || longestWord.Length < newWord.Length)
                        {
                            longestWord = newWord;
                        }

                        //check most vowels
                        int vowelsCount = CountVowels(newWord);
                        if (mostVowelsCount == 0 || mostVowelsCount < vowelsCount)
                        {
                            mostVowelsCount = vowelsCount;
                            mostVowels = newWord;
                        }
                    }
                }

                //close StreamReader
                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not open selected file! Error: " + ex.Message);
                return;
            }

            //display results
            lblFile.Show();
            lblAlphaFirst.Text = firstAlpha;
            lblAlphaFirst.Show();
            lblAlphaLast.Text = lastAlpha;
            lblAlphaLast.Show();
            lblLongest.Text = longestWord;
            lblLongest.Show();
            lblMostVowels.Text = mostVowels;
            lblMostVowels.Show();

            //try to write results to file
            try
            {
                StreamWriter outputFile = new StreamWriter("results.txt");
                outputFile.WriteLine(lblFile.Text);
                outputFile.WriteLine(lblAlphaFirstLabel.Text + " " + lblAlphaFirst.Text);
                outputFile.WriteLine(lblAlphaLastLabel.Text + " " + lblAlphaLast.Text);
                outputFile.WriteLine(lblLongestLabel.Text + " " + lblLongest.Text);
                outputFile.WriteLine(lblMostVowelsLabel.Text + " " + lblMostVowels.Text);

                //closing StreamWriter
                outputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not write to results file! Error: " + ex.Message);
                return;
            }
        }

        //takes in a string and counts the number of vowels in that string.
        private int CountVowels(string word)
        {
            int count = 0;
            string vowels = "aeiou";

            foreach(char c in word)
            {
                if(vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
