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
        public int Boredom { get; set; }
        public int Sleepiness { get; set; }
        public int Health { get; set; }

        public Pet(string Name)
        {
            Name = "LLAMAGACHI";
            Hunger = 0;
            Thirst = 0;
            Boredom = 0;
            Health = 0;
            Sleepiness = 0;
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
            if (Hunger < 0)
            {
                Hunger = 0;
                Console.WriteLine("{0};s hunger level is {1}", name, Hunger);
                Hunger += Tick();
            }
            else if (Thirst < 0)
            {
                Console.WriteLine("{0};s thirst level is {1}", name, Thirst);
                Thirst += Tick();
            }
            else if (Boredom < 0)
            {
                Console.WriteLine("{0};s boredom level is {1}", name, Boredom);
                Boredom += Tick();
            }
            else if (Sleepiness < 0)
            {
                Console.WriteLine("{0};s sleepiness level is {1}", name, Sleepiness);
                Sleepiness += Tick();
            }
            else if (Health < 0)
            {
                Console.WriteLine("{0};s health level is {1}", name, Health);
                Health += Tick();
            }
        }

        public void FeedPet()
        {
            Hunger += Tick();
            Stats();
            Console.WriteLine("You have fed your pet. Your pet's hunger is now {0}", Hunger);
        }
        public void GiveDrink()
        {

        }
        public void Play()
        {

        }
        public void PutToSleep()
        {

        }
        public void GiveMedicine()
        {

        }
    }
}
