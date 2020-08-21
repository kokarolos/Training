namespace CommandPattern
{
    public class CeilingFanLowcommand :ICommand
    {

        CeilingFan ceilingFan;
        int prevspeed;

        public CeilingFanLowcommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Excecute()
        {
            prevspeed = ceilingFan.GetSpeed();
            ceilingFan.Low();
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
