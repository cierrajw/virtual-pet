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
        public int Fullness { get; set; }
        public int Thirst { get; set; }
        public int Fun { get; set; }
        public int Energy { get; set; }
        public int Health { get; set; }
        //public int Poop; { get; set; }
        //public int Pee; { get; set; }

        public Pet()
        {
            name = "LLAMAGACHI";
            Fullness = 0;
            Thirst = 0;
            Fun = 0;
            Health = 0;
            Energy = 0;
            //Poop = 0;
            //Pee = 0;
      
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
            Thread.Sleep(3000);
        }

        public void Stats()
        {
            Console.WriteLine("                                      Fullness level: {0} ", Fullness);
            Console.WriteLine("                                      Hydration level: {0} ", Thirst);
            Console.WriteLine("                                      Fun level: {0} ", Fun);
            Console.WriteLine("                                      Energy level: {0} ", Energy);
            Console.WriteLine("                                      Health level: {0} ", Health);
        }

        public void FeedPet()
        {
            int maxHunger = 100;
            Fullness += Tick();
            Console.WriteLine("                              Yummy! My Fullness level is now {0}", Fullness);
            Console.WriteLine("\n");
            if(Fullness >= maxHunger)
            {
                Console.WriteLine("                          I'm too full, I need to poop!");
            }
        }
        public void GiveDrink()
        {
            int maxThirst = 100;
            Thirst += Tick();
            Console.WriteLine("                              Gulp! My hydration level is now {0}", Thirst);
            Console.WriteLine("\n");
            if(Thirst >= maxThirst)
            {
                Console.WriteLine("                          I've had enough to drink, I need to pee now!");
            }
        }
        //public int Poop() Tried to make this work, "already contains definition for" error occured.
        //{
        //    Hunger -= Tick();
        //}
        //public void Pee()
        //{
        //    Hunger -= Tick();
        //}
        public void Play()
        {
            int maxPlay = 100;
            int playInjury = 60;
            Fun += Tick();
            Console.WriteLine("                              Woohoo!!! My fun level is now {0}", Fun);
            Console.WriteLine("\n");
            if(Fun >= maxPlay)
            {
                Console.WriteLine("                          I've had enough play, I'd like to go to sleep now.");
            }
            else if(Fun >= playInjury)
            {
                Console.WriteLine("                          Oh noes, I think I played too much and hurted mahself. I need some medicine to get betters");
            }

        }
        public void PutToSleep()
        {
            int maxEnergy = 100;
            Energy += Tick();
            Console.WriteLine("                              Ahhh, much needed rest. My energy level is now {0}", Energy);
            Console.WriteLine("\n");
            if(Energy >= maxEnergy)
            {
                Console.WriteLine("                          I've had enough sleep, I want to play now!");
            }

        }
        public void GiveMedicine()
        {
            int maxMedicine = 100;
            Health += Tick();
            Console.WriteLine("                              My health level is now {0}", Health);
            Console.WriteLine("\n");
            if(Health >= maxMedicine)
            {
                Console.WriteLine("                          I feel healthy now, I don't need anymore medicine!");
            }
        }
    }
}
