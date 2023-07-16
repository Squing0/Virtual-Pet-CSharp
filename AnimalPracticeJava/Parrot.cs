using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class Parrot : Animal
    {
        public Parrot(string name) : base(name, "Parrot", "seeds")
        {

        }

        override
            public void communicate()
        {
            happinessActions(2, 1.5, 1);
            Console.WriteLine($"{name} is talking");
        }

        override
            public void play()
        {
            happinessActions(1.5, 1, 1);
            Console.WriteLine($"{name} is playing with it's toys");
        }
    }
}
