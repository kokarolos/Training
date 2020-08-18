namespace Command
{
    public class AirconditionOffCommand : ICommand
    {
        AirCondition _airCondition;

        public AirconditionOffCommand(AirCondition airCondition)
        {
            _airCondition = airCondition;
        }
        public void Execute()
        {
            _airCondition.Off();
        }

        public void Undo()
        {
            _airCondition.On();
        }
    }
}
