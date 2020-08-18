using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Ceiling
{
    public class CeilingFanMediumcommand:ICommand
    {
        CeilingFan ceilingFan;
        int prevspeed;

        public CeilingFanMediumcommand(CeilingFan ceilingFan )
        {
            this.ceilingFan = ceilingFan;
        }

        public void Excecute()
        {
            prevspeed = ceilingFan.GetSpeed();
            ceilingFan.Medium();
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
            else if (prevspeed == CeilingFan.OFF)
            {
                ceilingFan.Off();
            }
        }
    }
}
