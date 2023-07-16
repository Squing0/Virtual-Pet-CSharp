using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AnimalPracticeJava
{
    internal class Dog: Animal
    {
        public Dog(string name) : base(name,"Dog","Bones")
        {}

        override
        public void communicate() {
            happinessActions(2.5, 2, 1);
            Console.WriteLine($"{name} is barking.");                     
        }

        override
        public void play() 
        {
            happinessActions(2, 1.5, 1);
            Console.WriteLine($"{name} is playing fetch");

        }
    }
}
