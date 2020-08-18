namespace Command
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            _ceilingFan.On();
        }
    }
}
