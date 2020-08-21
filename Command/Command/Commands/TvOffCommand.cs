namespace Command
{
    public class TvOffCommand : ICommand
    {
        private TV _tv;

        public TvOffCommand(TV tv)
        {
            _tv = tv;
        }
        public void Execute()
        {
            _tv.Off();
        }

        public void Undo()
        {
            _tv.On();
        }
    }
}
