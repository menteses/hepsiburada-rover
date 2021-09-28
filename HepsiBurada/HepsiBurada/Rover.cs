using HepsiBurada.Instractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada
{
    public class Rover : IRover
    {
        private readonly InstractionManager _instractionManager;

        private Plateau _plateau;
        public Directions Direction { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Rover(InstractionManager instractionManager)
        {
            _instractionManager = instractionManager;
        }

        public void ToLand(Plateau plateau, int positionX, int positionY, Directions direction)
        {
            _plateau = plateau;
            PositionX = positionX;
            PositionY = positionY;
            Direction = direction;
        }

        public void DoInstractions(string instractionLetters)
        {
            var instractions = _instractionManager.ParseInstractions(this, instractionLetters);
            while (instractions.Count > 0)
            {
                instractions.Dequeue().Do();
            }
        }

        public override string ToString()
        {
            return $"{PositionX} {PositionY} {Direction}";
        }

        public void Move()
        {
            switch (Direction)
            {
                case Directions.N:
                    PositionY++;
                    break;
                case Directions.E:
                    PositionX++;
                    break;
                case Directions.S:
                    PositionY--;
                    break;
                case Directions.W:
                    PositionX--;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Directions.N:
                    Direction = Directions.W;
                    break;
                case Directions.E:
                    Direction = Directions.N;
                    break;
                case Directions.S:
                    Direction = Directions.E;
                    break;
                case Directions.W:
                    Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {

            switch (Direction)
            {
                case Directions.N:
                    Direction = Directions.E;
                    break;
                case Directions.E:
                    Direction = Directions.S;
                    break;
                case Directions.S:
                    Direction = Directions.W;
                    break;
                case Directions.W:
                    Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
    }
}
