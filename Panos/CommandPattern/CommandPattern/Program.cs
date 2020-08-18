using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl RemoteControl = new RemoteControl();

            Light LivingRoomlight = new Light("Living room");
            Light Kitchenlight = new Light("Kitchen room");
            CeilingFan ceilingfan = new CeilingFan("Living Room");
            GarrageDoor garagedoor = new GarrageDoor("");
            Stereo stereo = new Stereo("Living room");



            LightOnCommand livingroomLightOn = new LightOnCommand(LivingRoomlight);
            LightOfCommand livingroomLightOf = new LightOfCommand(LivingRoomlight);
            LightOnCommand kitchenLightOn = new LightOnCommand(Kitchenlight);
            LightOfCommand kitchenLightOf = new LightOfCommand(Kitchenlight);

            CeilingFanOncommand ceilingFanOncommand = new CeilingFanOncommand(ceilingfan);
            CeilingFanOfcommand ceilingFanOfcommand = new CeilingFanOfcommand(ceilingfan);

            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garagedoor);
            GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garagedoor);

            StereoOnWithCDCommand stereoOnWithCDCommand = new StereoOnWithCDCommand(stereo);
            StereoOfWithCDCommand stereoOfWithCDCommand = new StereoOfWithCDCommand(stereo);



            RemoteControl.SetCommand(0, livingroomLightOn, livingroomLightOf);
            RemoteControl.SetCommand(1, kitchenLightOn, kitchenLightOf);
            RemoteControl.SetCommand(2, ceilingFanOncommand, ceilingFanOfcommand);
            RemoteControl.SetCommand(3, stereoOnWithCDCommand, stereoOfWithCDCommand);


            System.Console.WriteLine(RemoteControl);


            RemoteControl.OnButtonWasPressed(0);
            RemoteControl.OnButtonWasPressed(1);
            RemoteControl.OnButtonWasPressed(2);
            RemoteControl.OffButtonWasPressed(1);



        }
    }
}
