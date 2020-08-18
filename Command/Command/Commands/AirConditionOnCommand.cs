namespace Command
{
    public class AirConditionOnCommand : ICommand
    {
        AirCondition _airCondition;

        public AirConditionOnCommand(AirCondition airCondition)
        {
            _airCondition = airCondition;
        }
        public void Execute()
        {
            _airCondition.On();
        }

        public void Undo()
        {
            _airCondition.Off();
        }
    }
}
