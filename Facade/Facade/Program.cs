namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var amplifier = new Amplifier();
            var cdPlayer = new CdPlayer(amplifier);
            var dvdPlayer = new DvdPlayer(amplifier);
            var tuner = new Tuner(amplifier);
            var theaterLights = new TheteaterLight();
            var popCornPopper = new PopcornPopper();
            var screen = new Screen();
            var projector = new Projector(dvdPlayer);

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amplifier,tuner,dvdPlayer,cdPlayer,
                theaterLights,popCornPopper,screen,projector);
            homeTheater.WatchMovie("Mr Bean");
        }
    }
}
