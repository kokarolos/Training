
using System;

namespace Composite
{
    public class Curves : Graphic
    {
        private float _xPos;
        private float _yPos;

        public Curves(float xPos, float yPos)
        {
            _xPos = xPos;
            _yPos = yPos;
        }

        public void Print()
        {
            Console.WriteLine($"{GetType().Name} drawn at {_xPos},{_yPos}");
        }
    }
}
