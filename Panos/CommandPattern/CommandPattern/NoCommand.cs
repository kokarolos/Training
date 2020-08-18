namespace CommandPattern
{
    public class NoCommand : ICommand
    {
        public void Excecute()
        {
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }



}
