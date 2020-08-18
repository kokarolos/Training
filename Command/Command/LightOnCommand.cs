namespace Command
{
    public class LightOnCommand : ICommand
    {
        Light _light;
        public void Execute()
        {
            _light.On();
        }
        public LightOnCommand(Light light)
        {
            _light = light;
        }

    }
}
