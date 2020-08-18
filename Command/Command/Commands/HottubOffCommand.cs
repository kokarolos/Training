namespace Command
{
    public class HottubOffCommand : ICommand
    {
        private Hottub _hottub;
        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void Execute()
        {
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.On();
        }
    }
}
