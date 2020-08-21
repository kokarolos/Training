namespace Command
{
    public class CeilingFanLowCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _previouSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previouSpeed = _ceilingFan.Speed;
            _ceilingFan.Low();
        }

        public void Undo()
        {
            if (_previouSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_previouSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_previouSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            }
            else
            {
                _ceilingFan.Off();
            }
        }
    }
}
