using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            //Light livingRoomLight = new Light("Living Room");
            //Light kitchenLight = new Light("Kitchen");
            //GarageDoor garageDoor = new GarageDoor();
            //Stereo stereo = new Stereo("Living room");
            //AirCondition airCondition = new AirCondition();
            //
            //LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            //LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //
            //LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            //LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            //
            //CeilingFanOnCommand ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            //CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);
            //
            //GarageDoorOpenCommand garageDoorUp = new GarageDoorOpenCommand(garageDoor);
            //GarageDoorCloseCommand garageDoorOff = new GarageDoorCloseCommand(garageDoor);
            //
            //StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            //StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            //
            //AirConditionOnCommand airCondtionOnCommand = new AirConditionOnCommand(airCondition);
            //AirconditionOffCommand airCondtionOffCommand = new AirconditionOffCommand(airCondition);
            //
            //remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            //remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            //remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            //remote.SetCommand(3, stereoOnWithCD, stereoOff);
            //remote.SetCommand(4, airCondtionOnCommand, airCondtionOffCommand);
            //
            //Console.WriteLine(remote);
            //
            //remote.OffButtonWasPressed(0);
            //remote.OffButtonWasPressed(1);
            //remote.OffButtonWasPressed(2);
            //remote.OffButtonWasPressed(3);
            //remote.OffButtonWasPressed(4);
            //Console.WriteLine();
            //remote.OnButtonWasPressed(0);
            //remote.OnButtonWasPressed(1);
            //remote.OnButtonWasPressed(2);
            //remote.OnButtonWasPressed(3);
            //remote.OnButtonWasPressed(4);

            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanLow, ceilingFanOffCommand);
            remote.SetCommand(1, ceilingFanMedium, ceilingFanOffCommand);
            remote.SetCommand(2, ceilingFanHigh, ceilingFanOffCommand);

            remote.OnButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OnButtonWasPressed(2);

            Console.WriteLine(remote);

            remote.OffButtonWasPressed(1);
            remote.UndoButtonWasPressed();
        }
    }
}
