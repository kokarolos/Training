namespace CommandPattern
{
    public class LightOfCommand : ICommand
    {
        Light light;

        public LightOfCommand(Light light)
        {
            this.light = light;
        }

        public void Excecute()
        {
            light.Of();
        }
        public void Undo()
        {
            light.On();
        }
    }
}
