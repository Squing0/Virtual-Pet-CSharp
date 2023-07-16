using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class OutsideRangeException : Exception
    {
        public OutsideRangeException(string message) : base(message) {

        }
    }
}
