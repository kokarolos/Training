namespace Facade
{
    public class Amplifier
    {
        Tuner _tuner;
        DvdPlayer _dvdPlayer;
        CdPlayer _cdPlayer;

        public Amplifier()
        {

        }

        public Amplifier(Tuner tuner,DvdPlayer dvdPlayer,CdPlayer cdPlayer)
        {
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
        }

        public void On()
        {

        }
        public void Off()
        {

        }
        public void SetCd()
        {

        }
        public void SetDvd()
        {

        }
        public void SetStereoSound()
        {

        }
        public void SetSurroundSound()
        {

        }
        public void SetTunes()
        {

        }
        public void SetVolume(int volume)
        {

        }

    }
}
