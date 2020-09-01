namespace Composite
{
    public class Painter
    {
        private CompositeGraphic _compositeGraphic;
        public Painter(CompositeGraphic compositeGraphic)
        {
            _compositeGraphic = compositeGraphic;
        }
        public void Paint()
        {
            _compositeGraphic.Print();
        }
    }
}
