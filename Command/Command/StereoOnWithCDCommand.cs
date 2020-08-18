namespace Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo _stereo;
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(15);
        }
        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
    }
}
