namespace CommandPattern
{
    public interface ICommand 
    {
        void Excecute();
        void Undo();
    }
}
