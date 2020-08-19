using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {

        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            Tuner tuner = new Tuner();
            DvdPlayer dvd = new DvdPlayer();
            CdPlayer cd = new CdPlayer();
            Projector projector = new Projector();
            TheaterLights lights = new TheaterLights();
            Screen screen = new Screen();
            PopcornPopper popper = new PopcornPopper();
            HomeTheatreFacade homeTheater = new HomeTheatreFacade(amp, tuner, dvd, cd, projector, lights, screen, popper);
        }
    }
}
