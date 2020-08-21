using System;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier _amplifier;
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;
        private TheteaterLight _theaterLights;
        private PopcornPopper _popcornPopper;
        private Screen _screen;
        private Projector _projector;

        public HomeTheaterFacade(Amplifier amplifier, Tuner tuner, DvdPlayer dvdPlayer,
            CdPlayer cdPlayer, TheteaterLight theaterLights, PopcornPopper popcornPopper, 
            Screen screen, Projector projector)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _theaterLights = theaterLights;
            _popcornPopper = popcornPopper;
            _screen = screen;
            _projector = projector;
        }
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch movie");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim();
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd();
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(10);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down");
            _popcornPopper.Off();
            _popcornPopper.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }
    }
}
