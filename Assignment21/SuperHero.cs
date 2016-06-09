using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{ /**
    * This class defines  a generic SuperHero class
    * 
    * @class SuperHero 
    * 
    * 
    * @field {string} _superpowers
    */
    public class SuperHero : Hero
    {
        //private instance variables
        private string[] _superPowers = new string[3];
        // public properties======================
        /**
         * <summary>
         *This is a property for superpowers field
         * </summary>
         * @property {string} superpowers
         */
        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }
            set
            {
                _superPowers = value; // value stored in superpowers instance variable
            }
        }
        public SuperHero(string n) : base(n)
        {
            Name = n;
            _generateRandomPowers();
        }
        // private methods
        /**
        * <summary>
        * This method randomly generates the ability numbers for the
        * super speed, super strength, body amour, flight, fire generations and wheather control
        * </summary>
        * @method _generateRandomPowers
        * @return {void}
        */
        
        private void _generateRandomPowers()
        {
            int[] arr = new int[] { 0, 0, 0, 0, 0, 0 };
            Random rand = new Random();
            for (int i = 0; i <= 2;)
            {
                int a = rand.Next(5) + 1;
                if (a == 1)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Super Speed";
                        i++;
                    }

                }
                else if (a == 2)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Super Strength";
                        i++;
                    }

                }
                else if (a == 3)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Body Armor";
                        i++;
                    }

                }
                else if (a == 4)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Flight: ";
                        i++;
                    }

                }
                else if (a == 5)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Fire Generation";
                        i++;
                    }

                }
                else if (a == 6)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " > This is our hero's Weather Control";
                        i++;
                    }

                }
            }
        }
        /**
         * <summary>
         * This method will display the Hero’s powers
         * </summary>
         * @method Show
         * @return {void}
         */
        public void ShowPowers()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(SuperPowers[i]);
            }
        }


    }
} 

