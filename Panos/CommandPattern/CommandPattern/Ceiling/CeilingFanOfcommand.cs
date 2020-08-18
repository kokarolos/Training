namespace CommandPattern
{
    public class CeilingFanOfcommand:ICommand
    {
        CeilingFan CeilingFan;

        public CeilingFanOfcommand(CeilingFan CeilingFan)
        {
            this.CeilingFan = CeilingFan;
        }

        public void Excecute()
        {
            CeilingFan.Of();
        }
    }

}
