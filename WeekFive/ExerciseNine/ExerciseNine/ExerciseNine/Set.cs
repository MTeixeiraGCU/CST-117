using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                //The program will always exit this loop on the first element. It should go through the
                //entire list and if it does not find a match, then return false.
                /*
                      else
                          return false;*/
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //This method should not alter either of the given Sets, It should create a new one from the union of both

            Set unionSet = new Set();

            //add the current set to the union
            for (int i = 0;i < this.elements.Count;i++)
            {
                unionSet.addElement(this.elements[i]);
            }

            //add the rhs elements to the union
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //This loop should not add to the current set but the new one
                /*this.addElement(rhs.elements[i]);*/
                unionSet.addElement(rhs.elements[i]);
            }

            //it should return the new set and not the rhs set
            /*return rhs;*/
            return unionSet;
        }
    }
}
