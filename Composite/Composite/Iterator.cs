namespace Composite
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}