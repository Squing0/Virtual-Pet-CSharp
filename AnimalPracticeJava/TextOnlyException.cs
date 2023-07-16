using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPracticeJava
{
    internal class TextOnlyException : Exception
    {
        public TextOnlyException(string message) : base(message) {

        }
    }
}
