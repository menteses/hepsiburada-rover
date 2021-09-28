using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Instractions
{
    [InstractionLetter(letter: 'M')]
    public class MoveInstraction : IInstraction
    {
        private readonly IMoveable moveable;

        public MoveInstraction(IMoveable moveable)
        {
            this.moveable = moveable;
        }

        public void Do()
        {
            moveable.Move();
        }
    }
}
