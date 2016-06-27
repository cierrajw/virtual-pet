using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 V");
            Console.WriteLine("                /'>>>   Hello, I am your LLAMAGACHI! What would you like to do?!");
            Console.WriteLine("               /*/");
            Console.WriteLine("              / /");
            Console.WriteLine("             /*/");
            Console.WriteLine("            / /");
            Console.WriteLine("    -------/*/");
            Console.WriteLine(" --/  *  * */");
            Console.WriteLine("  /* * *  */");
            Console.WriteLine("  -  --- -/");
            Console.WriteLine("   H    H");
            Console.WriteLine("   H    H");
            Console.WriteLine("   --   --");


            Console.WriteLine("1. Feed me!");
            Console.WriteLine("2. Give me a drink!");
            Console.WriteLine("3. Play with me!");
            Console.WriteLine("4. Put me to sleep!");
            Console.WriteLine("5. Give me some medicine!");
            Console.WriteLine("6. Exit");

            //Creating objects
            Pet feed = new Pet("");
            Pet drink = new Pet("");
            Pet play = new Pet("");
            Pet sleep = new Pet("");
            Pet medicine = new Pet("");

            int choice = Convert.ToInt32(Console.ReadLine()); 

            if(choice == 6)
            {
                //
            }
            else if(choice == 1)
            {
                feed.FeedPet();
            }
            else if(choice == 2)
            {
                //drink.GiveDrink();
            }
            else if(choice == 3)
            {
                //play.Play();
            }
            else if(choice == 4)
            {
                //sleep.PutToSleep();
            }
            else if(choice == 5)
            {
                //medicine.GiveMedicine();
            }
            Console.ReadKey();

        }
    }
}
