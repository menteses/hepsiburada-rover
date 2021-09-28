using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Instractions
{

    [InstractionLetter(letter:'R')]
    public class TurnRightInstraction : IInstraction
    {
        private readonly IRightRotate rotateable;

        public TurnRightInstraction(IRightRotate rotateable)
        {
            this.rotateable = rotateable;
        }
        public void Do()
        {
            rotateable.TurnRight();

        }
    }
}
