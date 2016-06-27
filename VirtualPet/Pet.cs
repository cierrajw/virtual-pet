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
                FeedPet();
                Stats();
                Menu();
            }
            else if (choice == 2)
            {
                GiveDrink();
                Stats();
                Menu();
            }
            else if (choice == 3)
            {
                Play();
                Stats();
                Menu();
            }
            else if (choice == 4)
            {
                PutToSleep();
                Stats();
                Menu();
            }
            else if (choice == 5)
            {
                GiveMedicine();
                Stats();
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
            Thread.Sleep(500);
        }

        public void Stats()
        {
            Console.WriteLine("                                      Hunger level: {0} ", Hunger);
            Console.WriteLine("                                      Thirst level: {0} ", Thirst);
            Console.WriteLine("                                      Boredom level: {0} ", Fun);
            Console.WriteLine("                                      Energy level: {0} ", Energy);
            Console.WriteLine("                                      Health level: {0} ", Health);
        }

        //public void Stats()
        //{
        //    if (Hunger < 0)
        //    {
        //        Hunger = 0;
        //        Console.WriteLine("{0};s hunger level is {1}", name, Hunger);
        //        Hunger += Tick();
        //    }
        //    else if (Thirst < 0)
        //    {
        //        Console.WriteLine("{0};s thirst level is {1}", name, Thirst);
        //        Thirst += Tick();
        //    }
        //    else if (Boredom < 0)
        //    {
        //        Console.WriteLine("{0};s boredom level is {1}", name, Boredom);
        //        Boredom += Tick();
        //    }
        //    else if (Sleepiness < 0)
        //    {
        //        Console.WriteLine("{0};s sleepiness level is {1}", name, Sleepiness);
        //        Sleepiness += Tick();
        //    }
        //    else if (Health < 0)
        //    {
        //        Console.WriteLine("{0};s health level is {1}", name, Health);
        //        Health += Tick();
        //    }
        //}

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
