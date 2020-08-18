namespace CommandPattern
{
    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Excecute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Of();
        }
    }
}
