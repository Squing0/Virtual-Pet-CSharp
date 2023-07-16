using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal abstract class Animal
    {
        public string name { get; private set; } // First 3 made private set so that only set once with constructor!
        public string species { get; private set; }
        public string food { get; private set; }
        public double hunger {get;set;}
        public double happiness { get; set; }
        public double energy { get; set; }
        public int happinessCounter { get;set ; }

        public Animal(string n, string s, string f)     // May be hard to get name to work here
        {
            name = n;
            species = s;
            food = f;
            hunger = 5;
            happiness = 5;
            energy = 5;
            happinessCounter = 0;

         
        }

        public void sleep() 
        {
            energy += 2.5;
            hunger += 1;
            happiness -= 0.5;   //Could be automated?

            Console.WriteLine($"{name} is sleeping.");

            if (energy >= 10) 
            {
                energy = 10;
            }

            happinessCounter += 1;
            checkHappinessCounter();
        }

        public void eat()
        {
            hunger -= 2;
            Console.WriteLine($"{name} is eating {food}.");

            if (hunger <= 0)
            {
                hunger = 0;
            }

            happinessCounter += 1;
            checkHappinessCounter();
        }

        public abstract void communicate();
        public abstract void play();
        
        public void displayStats()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Species: {species}");
            Console.WriteLine($"Food: {food}");
            Console.WriteLine(createBar("Hunger:", hunger));
            Console.WriteLine(createBar("Happiness:", happiness));
            Console.WriteLine(createBar("Energy:", energy));
        }
        public string createBar(string name, double currentHealth) 
        {
            int max = 10;
            int length = 10;
            double healthRatio = currentHealth/max;
            int barFillLength = (int) (healthRatio * length);

            string barFill = Repeat("|", barFillLength);
            string BarEmpty = Repeat(" ", length - barFillLength);

            return $"{name} [{barFill}{BarEmpty}] {currentHealth} / {max}";


        }
        public static string Repeat(string single, int n)
        {
            if(n <= 0)
            {
                return null;
            }

            if(string.IsNullOrEmpty(single) || n == 1)
            {
                return single;
            }

            return new StringBuilder(single.Length * n).Insert(0, single, n).ToString();
        }
        public void checkHappinessCounter()
        {
            if(happinessCounter >= 3)
            {
                happiness -= 2;
                Console.WriteLine($"{name} is feeling neglected.");
            }
        }

        public void happinessActions(double happinessNum, double energyNum, double hungerNum) {
            happiness += happinessNum;
            if (happiness >= 10)
            {
                happiness = 10;
            }

            energy -= energyNum;
            hunger += hungerNum;
            happinessCounter = 0;
        }
        public Boolean checkDeath()
        {
            return hunger >= 10 || energy <= 0 || happiness <= 0;
        }

        public void checkStats(double stat, double compare, Boolean decision, string state)
        {
            if (decision == true)
            {
                if (stat >= compare)
                {
                    Console.WriteLine($"{name}{state}");
                }
            }
            else
            {
                if (stat <= compare)
                {
                    Console.WriteLine($"{name}{state}");
                }
            }
        }

        public void checkHappiness()
        {
            checkStats(happiness, 8, true, " is very happy.");
            checkStats(happiness, 4, false, " is sad.");        
        }

        public void checkHunger()
        {
            checkStats(hunger, 8, true, " is very hungry.");
            checkStats(hunger, 0, false, " is full!");
        }

        public void checkEnergy()
        {
            checkStats(energy, 10, true, " is full of energy!");
            checkStats(energy, 4, false, " is tired.");
        }

    }
}
