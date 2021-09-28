using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Instractions
{

    [InstractionLetter(letter:'L')]
    public class TurnLeftInstraction : IInstraction
    {
        private readonly ILeftRotate rotateable;

        public TurnLeftInstraction(ILeftRotate rotateable)
        {
            this.rotateable = rotateable;
        }
        public void Do()
        {
            rotateable.TurnLeft();
        }
    }
}
