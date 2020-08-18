using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living room");

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOnCommand livingRoomLightOff = new LightOnCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOnCommand kitchenLightOff = new LightOnCommand(kitchenLight);

            CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOnCommand ceilingFanOff = new CeilingFanOnCommand(ceilingFan);

            GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            GarageDoorOpenCommand garageDoorOff = new GarageDoorOpenCommand(garageDoor);

            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOnWithCDCommand stereoOff = new StereoOnWithCDCommand(stereo);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOnWithCD, stereoOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OnButtonWasPressed(2);
            remote.OffButtonWasPressed(3);
            remote.OffButtonWasPressed(0);
            remote.OffButtonWasPressed(1);
            remote.OffButtonWasPressed(2);
            remote.OffButtonWasPressed(3);


        }
    }
}
