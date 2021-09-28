using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace HepsiBurada.Instractions
{
    public class InstractionManager
    {
        private Dictionary<char, Type> _instractions;

        public InstractionManager()
        {
            _instractions = Assembly.GetAssembly(typeof(IInstraction)).GetTypes().Where(x => x.IsClass && !x.IsAbstract && typeof(IInstraction).IsAssignableFrom(x)).ToDictionary(x => x.GetCustomAttribute<InstractionLetterAttribute>().Letter, x => x);
        }

        public Queue<IInstraction> ParseInstractions(IRover rover, string instractions)
        {
            var queue = new Queue<IInstraction>();
            foreach (var instractionLetter in instractions)
            {
                queue.Enqueue(GetInstraction(rover, instractionLetter));
            }

            return queue;
        }

        public IInstraction GetInstraction(IRover rover, char letter)
        {
            var instraction = _instractions.GetValueOrDefault(letter);
            if (instraction == null)
            {
                throw new Exception("Unknown instraction");
            }

            return Activator.CreateInstance(instraction, rover) as IInstraction;
        }

    }

}
