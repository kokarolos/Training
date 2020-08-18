namespace Command
{
    public class HottubOnCommand : ICommand
    {
        private Hottub _hottub;
        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void Execute()
        {
            _hottub.On();
        }

        public void Undo()
        {
            _hottub.Off();
        }
    }
}
