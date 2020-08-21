namespace Command
{
    public class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _previouSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previouSpeed = _ceilingFan.Speed;
            _ceilingFan.Medium();
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
