using System.Text;

namespace CommandPattern
{
    public class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;
        ICommand UndoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            UndoCommand =new NoCommand();
        }


        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            _onCommands[slot].Excecute();
            UndoCommand = _onCommands[slot];
        }



        public void OffButtonWasPressed(int slot)
        {
            _offCommands[slot].Excecute();
            UndoCommand = _offCommands[slot];
        }
        public void UndoButtonWasPushed()
        {
            UndoCommand.Undo();
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n--------Remote Control ---------\n");
            for (int i = 0; i < _onCommands.Length; i++)
            {
                stringBuilder.Append($"slot {i} {_onCommands[i].GetType().Name}" + 
                    $" , {_offCommands[i].GetType().Name} \n");
            }
            return stringBuilder.ToString();
        }
    }
}
