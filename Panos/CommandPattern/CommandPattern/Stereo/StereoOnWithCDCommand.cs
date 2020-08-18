namespace CommandPattern
{
    public class StereoOnWithCDCommand : ICommand
    {
        Stereo Stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Excecute()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume(11);
        }
    }


}
