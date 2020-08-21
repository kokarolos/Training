namespace CommandPattern
{
    public class CeilingFanOfcommand:ICommand
    {
        CeilingFan ceilingFan;
        int prevspeed;

        public CeilingFanOfcommand(CeilingFan CeilingFan)
        {
            this.ceilingFan = CeilingFan;
        }

        public void Excecute()
        {
            prevspeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
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
