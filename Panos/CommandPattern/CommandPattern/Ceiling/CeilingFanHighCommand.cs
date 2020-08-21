using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan ceilingFan;
        int prevspeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Excecute()
        {
            prevspeed = ceilingFan.GetSpeed();
            ceilingFan.High();
        }

        public void Undo()
        {
            if (prevspeed == CeilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevspeed == CeilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevspeed == CeilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevspeed==CeilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
