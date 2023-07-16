using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class Cat : Animal
    {
        public Cat(string name): base(name,"Cat","Meat"){}

        override
        public void communicate()
        {
            happinessActions(2.5, 2, 1);
            Console.WriteLine($"{name} is meowing");

        }
        override
        public void play()
        {
            happinessActions(1.5,1.5,1);
            Console.WriteLine($"{name} is playing with a ball of yarn");
        }
    }
}
