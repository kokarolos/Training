namespace CommandPattern
{
    public class CeilingFanOncommand :ICommand
    {

        CeilingFan CeilingFan;

        public CeilingFanOncommand(CeilingFan CeilingFan)
        {
            this.CeilingFan = CeilingFan;
        }

        public void Excecute()
        {
            CeilingFan.On();
        }
    }

}
