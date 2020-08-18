namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarrageDoor garagedoor;

        public GarageDoorOpenCommand(GarrageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }

        public void Excecute()
        {
            garagedoor.Up();
        }
    }


}
