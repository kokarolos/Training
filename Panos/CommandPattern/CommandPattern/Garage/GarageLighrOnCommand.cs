namespace CommandPattern
{
    public class GarageLighrOnCommand : ICommand
    {
        GarrageDoor garagedoor;

        public GarageLighrOnCommand(GarrageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }

        public void Excecute()
        {
            garagedoor.Up();
        }
    }


}
