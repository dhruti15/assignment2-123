using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Patel DHRUTI
* Student Number: 300857555
* Date: June 9, 2016
* Date Modified: June 9, 2016
* Description: The SuperHero Class Assignment 2
* Version: 0.0.2 Added documentation.
*/
namespace Assignment21
{ /**<summary> This class defines  a generic SuperHero class
     *</summary>
    *
    * 
    * @class SuperHero 
    * 
    * 
    * @field {stringArray} _superpowers
    */
     class SuperHero : Hero
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
         * This is method creates super powers for the hero and assigns 
         * 3 super powers to the hero. The list creates an array for the 
         * super powers.
         * The add atribute adds the number of powers in the list.
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
                        SuperPowers[i] = " >~~~~~ Time for Super Speed";
                        i++;
                    }

                }
                else if (a == 2)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " >~~~~~ Time for Super Strength";
                        i++;
                    }

                }
                else if (a == 3)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " >~~~~~ Time for Body Armor";
                        i++;
                    }

                }
                else if (a == 4)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " >~~~~~ Time for Flight: ";
                        i++;
                    }

                }
                else if (a == 5)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " >~~~~~ Time for Fire Generation";
                        i++;
                    }

                }
                else if (a == 6)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = " >~~~~~ Time for Weather Control";
                        i++;
                    }

                }
            }
        }
        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method outputs the super powers of the hero
         * to the console
         * </summary>
         * @method ShowPowers
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

