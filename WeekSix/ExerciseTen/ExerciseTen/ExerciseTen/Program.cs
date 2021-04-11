using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ExerciseTen
{
    class Program
    {
        static void Main(string[] args)
        {
            //counter for the number of trailing t and e characters
            int numOfCharacters = 0;

            //file to open
            string fileName = "";

            //the list of parsed words
            List<string> words = new List<string>();

            //check for command line filename
            if (args.Length == 1)
            {
                fileName = args[0];
            }
            else
            {
                fileName = "../../../../testFile.txt";
            }

            // try to open file stream and initialize list of words
            try
            {
                StreamReader fileReader = File.OpenText(fileName);

                //loop through the file a line at a time until we reach the end
                string line;
                while ((line = fileReader.ReadLine()) != null)
                {
                    //split each line up into individual words and remove non alpha characters from it
                    foreach (string word in line.Split(' '))
                    {
                        string trimmedWord = Regex.Replace(word, @"[^a-zA-Z]", "");
                        words.Add(trimmedWord);
                    }
                }

                //close the file stream
                fileReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Could not open and parse file: " + fileName + ". Error: " + ex.Message);
                return;
            }
            

            //loop through the words to find the number of trailing t and e characters
            foreach(string word in words)
            {
                if(word.EndsWith('t') || word.EndsWith('e'))
                {
                    numOfCharacters++;
                }
            }

            //print the results to the console
            Console.WriteLine("There are/is " + numOfCharacters + " words that end in t or e!");
        }
    }
}
