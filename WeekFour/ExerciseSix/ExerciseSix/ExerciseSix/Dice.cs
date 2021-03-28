using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSix
{
    /**
     * <summary>This class represents a die with between 4 and 20 sides. It can be "rolled" to get a random side.</summary>
     */
    public class Dice
    {
        //number of sides on the die
        private readonly int _sides;

        //random number generator for Dice class
        private static Random _randomNumber;

        //constructor, sides must be between 4 and 20
        public Dice(int sides)
        {
            //set the number of sides
            if(sides < 4 || sides > 20)
            {
                throw new ArgumentOutOfRangeException("sides", "Must be between 4 and 20 inclusive!");
            }
            _sides = sides;

            //seed the random number generator if it needs
            if(_randomNumber == null)
            {
                _randomNumber = new Random();
            }
        }

        //generate a random number between 1 and the number of sides to simulate a die roll
        public int rollDie()
        {
            return (_randomNumber.Next(_sides) + 1);
        }
    }
}
