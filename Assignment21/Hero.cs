using System;

namespace Assignment21
{
    /**
    * This class defines  a generic Hero class
    * 
    * @class Hero 
    * @field {int} _strength
    * @field {int} _speed
    * @field {int} _health
    * @field {string} _name
    */
    public class Hero
    {
        // private instance variables==============
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // public properties======================
        /**
         * <summary>
         *This is a property for our _name field
         * </summary>
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value; // value stored in name instance variable
            }
        }

        // private methods
        /**
        * <summary>
        * This method randomly generates the ability numbers for the
        * strength, speed and health properties
        * </summary>
        * @method _generateAbilities
        * @return {void}
        */
        // random abilities for strength, speed, health generated between 1-100
        private void _generateAbilities()
        {
            Random rand = new Random();

            // Random number is generated between (0-99) therefore +1 is used to avoid 0 as 0 +1 = 1 and 99 +1 = 100
            _strength = rand.Next(99) + 1;
            _health = rand.Next(99) + 1;
            _speed = rand.Next(99) + 1;
        }
        /**
         * <summary>
         * This method determines if the hero hits 
         * </summary>
         * @method hitAttempt
         * @return {bool}
         */
        private bool _hitAttempt()
        {
            Random rand = new Random();
            // (number generated between 0-4 i.e. 5 numbers(100/5=20) therefore 4 is used for 20% probability
            int hit = rand.Next(4);
            if (hit == 0) // checks for 20% probability to hit
            {
                return true; // hit
            }
            else
                return false; // no hit
        }
        /**
         * <summary>
         * Method that calculates the damage the Hero causes to the target
         * on a hit by multiplying a number between 1, 6 by strenght.
         * </summary>
         * @method hitDamage
         * @return {int}
         */
        private int _hitDamage()
        {
            int damage;
            Random rand = new Random();
            // damage calculated by multiplying strength with a number between 1-6
            damage = _strength * (rand.Next(5) + 1);
            return damage;
        }

        // public methods
        /**
         * <summary>
         * This method calls the hitAttempt method and if returns
         * true it calls the hitDamage method and the damaged amount is passed 
         * to the console
         * </summary>
         * @method Fight
         * @return {void}
         */
        public void Fight()
        {
            int damage;
            if (_hitAttempt()) // hitAttempt called and if true damage(hero hits) then damage is calculated
            {
                damage = _hitDamage(); // damage is calculated in _hitDamage method and then stored in damage
                Console.WriteLine("Damage Amount: " + damage);
            }
            else
            {
                Console.WriteLine("oops! Missed you.");
            }
        }
        /**
         * <summary>
         * This method will display the Hero’s ability scores to the console
         * </summary>
         * @method Show
         * @return {void}
         */
        public void Show()
        {
            Console.WriteLine(" > Hi! {0} the hero. ", _name);
            Console.WriteLine(" > This is our hero's Strength: " + _strength);
            Console.WriteLine(" > This is our hero's Speed: " + _speed);
            Console.WriteLine(" > This is our hero's Health: " + _health);
        }

        //Constructor
        public Hero(string name)
        {
            _name = name; // name is stored in _name instance variable
            _generateAbilities(); //_generateAbilities method is called
        }
    }
}