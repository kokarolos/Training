using System;
using System.Net.Http.Headers;
using CommandPattern.Ceiling;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl RemoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOfCommand lightOf = new LightOfCommand(light);

            CeilingFan ceiling = new CeilingFan("Living Room");

            CeilingFanLowcommand fanLowcommand = new CeilingFanLowcommand(ceiling);
            CeilingFanHighCommand chigh = new CeilingFanHighCommand(ceiling);

            CeilingFanOfcommand fanOfcommand = new CeilingFanOfcommand(ceiling);

            GarrageDoor gd = new GarrageDoor("Garrage");
            GarageDoorOpenCommand gopen = new GarageDoorOpenCommand(gd);
            GarageDoorCloseCommand gclose = new GarageDoorCloseCommand(gd);



            ICommand[] partyOn = { lightOn,gopen, chigh };
            ICommand[] partyOff = { lightOf,gclose, fanLowcommand };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            RemoteControl.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(RemoteControl);
            Console.WriteLine("-----Pushing Macro On----");
            RemoteControl.OnButtonWasPressed(0);
            Console.WriteLine("--------- Pushing Macro Of------");
            RemoteControl.OffButtonWasPressed(0);



        }
    }
}
