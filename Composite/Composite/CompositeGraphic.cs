using System.Collections.Generic;

namespace Composite
{
    public class CompositeGraphic : Graphic
    {
        private List<Graphic> _childGraphics;

        public CompositeGraphic()
        {
            _childGraphics = new List<Graphic>();
        }

        public void Add(Graphic graphic)
        {
            _childGraphics.Add(graphic);
        }

        public void Print()
        {
            foreach (var graphic in _childGraphics)
            {
                graphic.Print();
            }
        }
    }
}
