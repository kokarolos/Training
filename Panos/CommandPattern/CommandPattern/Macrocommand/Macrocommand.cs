using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class MacroCommand : ICommand
    {
        ICommand[] Commands;

        public MacroCommand(ICommand[]commands)
        {
            this.Commands = commands;
        }

        public void Excecute()
        {
            for (int i = 0; i < Commands.Length; i++)
            {
                Commands[i].Excecute();
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
