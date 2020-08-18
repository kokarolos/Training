namespace CommandPattern
{
    public class GarageDoorCloseCommand : ICommand
    {
        GarrageDoor garagedoor;

        public GarageDoorCloseCommand(GarrageDoor garagedoor)
        {
            this.garagedoor = garagedoor;
        }

        public void Excecute()
        {
            garagedoor.Down();
        }

        public void Undo()
        {
            garagedoor.Up();
        }
    }


}
