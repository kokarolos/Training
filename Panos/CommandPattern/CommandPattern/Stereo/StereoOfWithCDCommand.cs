namespace CommandPattern
{
    public class StereoOfWithCDCommand : ICommand
    {
        Stereo Stereo;

        public StereoOfWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Excecute()
        {
            Stereo.Of();
        }

        public void Undo()
        {
            Stereo.On(); 
        }
    }
}
