using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace VirtualPet
{
    class Pet
    {
        Random random = new Random();
        private string name { get; set; }
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Fun { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }

        public Pet()
        {
            name = "LLAMAGACHI";
            Hunger = 0;
            Thirst = 0;
            Fun = 0;
            Health = 0;
            Energy = 0;
        }

        public void Menu()
        {
            Console.WriteLine("\n1. Feed me!");
            Console.WriteLine("2. Give me a drink!");
            Console.WriteLine("3. Play with me!");
            Console.WriteLine("4. Put me to sleep!");
            Console.WriteLine("5. Give me some medicine!");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 6)
            {
                Environment.Exit(0);
            }
            else if (choice == 1)
            {
                Time();
                FeedPet();
                Stats();
                Menu();
            }
            else if (choice == 2)
            {
                Time();
                GiveDrink();
                Stats();
                Menu();
            }
            else if (choice == 3)
            {
                Time();
                Play();
                Stats();
                Menu();
            }
            else if (choice == 4)
            {
                Time();
                PutToSleep();
                Stats();
                Menu();
            }
            else if (choice == 5)
            {
                Time();
                GiveMedicine();
                Stats();
                Menu();
            }
            else
            {
                Console.WriteLine("Please enter a valid menu option");
                Menu();
            }
            Console.ReadKey();

        }

        public int Tick()
        {
            int tick = random.Next(1, 10);
            return tick;
        }

        public void Time()
        {
            Console.WriteLine("Hold on a sec...");
            Thread.Sleep(4000);
        }

        public void Stats()
        {
            Console.WriteLine("                                      Hunger level: {0} ", Hunger);
            Console.WriteLine("                                      Thirst level: {0} ", Thirst);
            Console.WriteLine("                                      Boredom level: {0} ", Fun);
            Console.WriteLine("                                      Energy level: {0} ", Energy);
            Console.WriteLine("                                      Health level: {0} ", Health);
        }

        public void FeedPet()
        {
            Hunger += Tick();
            Console.WriteLine("                              Yummy! My hunger level is now {0}", Hunger);
            Console.WriteLine("\n");
        }
        public void GiveDrink()
        {
            Thirst += Tick();
            Console.WriteLine("                              Gulp! My thirst level is now {0}", Thirst);
            Console.WriteLine("\n");
        }
        public void Play()
        {
            Fun += Tick();
            Console.WriteLine("                              My boredom level is now {0}", Fun);
            Console.WriteLine("\n");
        }
        public void PutToSleep()
        {
            Energy += Tick();
            Console.WriteLine("                              My sleepiness level is now {0}", Energy);
            Console.WriteLine("\n");
        }
        public void GiveMedicine()
        {
            Health += Tick();
            Console.WriteLine("                              My health level is now {0}", Health);
            Console.WriteLine("\n");
        }
    }
}
