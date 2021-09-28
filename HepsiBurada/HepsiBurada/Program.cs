using HepsiBurada.Instractions;
using System;

namespace HepsiBurada
{
    class Program
    {
        static void Main(string[] args)
        {

           var input = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";
            var nasa = new Nasa();
            nasa.Build(input);

            Console.ReadKey();
        }
    }
}
