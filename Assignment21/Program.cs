using System;

namespace Assignment21
{

    /**
   * This class is the driver class for our program 
   * 
   * @class Program
   */
    public class Program
    {
        /**
       * The main method for our driver class Program
       * 
       * @method main
       * @param {string[]} args
       */
        public static void Main()
        {
            try
            {
                Hero hero = new Hero("DHRUTI");// Object for Hero is created and implemented
                hero.Show();// Show method of Hero is called
                hero.Fight();// Fight method of Hero is called

                SuperHero super = new SuperHero("DHRUTI");
                super.Show();
                super.ShowPowers();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
    }
}
}