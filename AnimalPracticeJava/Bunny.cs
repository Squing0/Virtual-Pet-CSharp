using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class Bunny : Animal
    {
        public Bunny(string name) : base(name, "Bunny", "Carrots") { }
        override
        public void communicate()
        {
            happinessActions(2, 1.5, 1);
            Console.WriteLine($"{name} is thumping its foot");
        }
        override
        public void play()
        {
            happinessActions(1.5,1.5,1);
            Console.WriteLine($"{name} is hopping around");
        }
    }
}
