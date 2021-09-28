using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Instractions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InstractionLetterAttribute : Attribute
    {
        public char Letter { get; private set; }

        public InstractionLetterAttribute(char letter)
        {
            Letter = letter;
        }
    }
}
