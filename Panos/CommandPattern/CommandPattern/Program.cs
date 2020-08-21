using System;
using CommandPattern.Ceiling;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            RemoteControl RemoteControl = new RemoteControl();

            Light light = new Light("Living Room");
            CeilingFan ceiling = new CeilingFan("Living Room");
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOfCommand lightOf = new LightOfCommand(light);
            CeilingFanLowcommand fanLowcommand = new CeilingFanLowcommand(ceiling);
            CeilingFanOfcommand fanOfcommand = new CeilingFanOfcommand(ceiling);


            ICommand[] partyOn = { lightOn, fanLowcommand };
            ICommand[] partyOff = { lightOf, fanOfcommand };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            RemoteControl.SetCommand(0, partyOnMacro, partyOffMacro);


        }
    }
}
