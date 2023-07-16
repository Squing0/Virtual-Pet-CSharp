using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class Hamster : Animal
    {
        public Hamster(string name) : base(name, "Hamster", "seeds")
        {

        }

        override
            public void communicate()
        {
            happinessActions(1.5, 1, 1);
            Console.WriteLine($"{name} is squeaking");
        }

        override
            public void play()
        {
            happinessActions(1, 2, 1);
            Console.WriteLine($"{name} is running on it's wheel");
        }
    }
}
