using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    public class SuperHero : Hero
    {
        private string[] _superPowers = new string[3];

        public string[] SuperPowers
        {
            get
            {
                return _superPowers;
            }
            set
            {
                _superPowers = value;
            }
        }
        public SuperHero(string n) : base(n)
        {
            Name = n;
            _generateRandomPowers();
        }
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
                        SuperPowers[i] = "Super Speed";
                        i++;
                    }

                }
                else if (a == 2)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = "Super Strength";
                        i++;
                    }

                }
                else if (a == 3)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = "Body Armor";
                        i++;
                    }

                }
                else if (a == 4)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = "Flight";
                        i++;
                    }

                }
                else if (a == 5)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = "Fire Generation";
                        i++;
                    }

                }
                else if (a == 6)
                {
                    if (arr[a - 1] == 0)
                    {
                        arr[a - 1] = 1;
                        SuperPowers[i] = "Weather Control";
                        i++;
                    }

                }
            }
        }
        public void ShowPowers()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(SuperPowers[i]);
            }
        }


    }
} 

