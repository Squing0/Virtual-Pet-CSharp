using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class Fish : Animal
    {
        public Fish(string name) : base(name, "Fish", "flakes") 
        {
        }

        override
            public void communicate()
        {
            happinessActions(1.5, 1, 1);
            Console.WriteLine($"{name} is swimming");
        }

        override
            public void play()
        {
            happinessActions(2, 1, 1);
            Console.WriteLine($"{name} is swimming excitedly");
        }
    }
}
