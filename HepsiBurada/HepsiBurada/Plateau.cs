using System;
using System.Collections.Generic;

namespace HepsiBurada
{
    public class Plateau
    {
        public int RightTopCornerPositionX { get; private set; }
        public int RightTopCornerPositionY { get; private set; }

        public Plateau(int rightTopCornerPositionX, int rightTopCornerPositionY)
        {
            RightTopCornerPositionX = rightTopCornerPositionX;
            RightTopCornerPositionY = rightTopCornerPositionY; 
        }

    }
}