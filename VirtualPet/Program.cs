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

            int choice = Convert.ToInt32(Console.ReadLine());

            Pet myPet = new Pet(); //Object

            if(choice == 6)
            {
                Environment.Exit(0);
            }
            else if(choice == 1)
            {
                myPet.FeedPet();
                myPet.Stats();
                myPet.Menu();
            }
            else if(choice == 2)
            {
                myPet.GiveDrink();
                myPet.Stats();
                myPet.Menu();
            }
            else if(choice == 3)
            {
                myPet.Play();
                myPet.Stats();
                myPet.Menu();
            }
            else if(choice == 4)
            {
                myPet.PutToSleep();
                myPet.Stats();
                myPet.Menu();
            }
            else if(choice == 5)
            {
                myPet.GiveMedicine();
                myPet.Stats();
                myPet.Menu();
            }
            else
            {
                Console.WriteLine("Please enter a valid menu option");
                myPet.Menu();
            }
            Console.ReadKey();
        }
    }
}
