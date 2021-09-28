using HepsiBurada.Instractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HepsiBurada
{
    public class Nasa
    {
        public void Build(string input)
        {
            var instractions = new Stack<string>(input.Split("\r\n").Select(x => x.Trim()).Reverse());

            var platauePositions = instractions.Pop().Split(' ').Select(x =>
            {
                return Convert.ToInt32(x);
            }
            ).ToList();

            var plataue = CreatePlateau(platauePositions[0], platauePositions[1]);


            while (instractions.Count > 0)
            {
                var roverLaunchInstraction = instractions.Pop();
                var roverPositions = roverLaunchInstraction.Split(' ').Where((x, index) => index < 2).Select(x => Convert.ToInt32(x)).ToList();
                var direction = Enum.Parse<Directions>(roverLaunchInstraction.Split(' ')[2]);
                var rover = CreateRover();
                Launch(rover, plataue, roverPositions[0], roverPositions[1], direction);
                var instraction = instractions.Pop();
                rover.DoInstractions(instraction);
                Console.WriteLine(rover);
            }
        }

        private Plateau CreatePlateau(int x, int y)
        {
            return new Plateau(x, y);
        }

        private Rover CreateRover()
        {
            var instractionManager = CreateInstractionManager();
            return new Rover(instractionManager);
        }

        private void Launch(Rover rover, Plateau plateau, int x, int y, Directions direction)
        {
            rover.ToLand(plateau, x, y, direction);
        }

        private InstractionManager CreateInstractionManager()
        {
            return new InstractionManager();
        }
        
    }
}
