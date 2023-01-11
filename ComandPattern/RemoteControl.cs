using System.Text;

namespace CommandPattern
{
    //реализация пульта управления
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;//теперь мы знаем, что в каждой ячейке всегда присутствует допустимая команда.
                offCommands[i] = noCommand;//теперь мы знаем, что в каждой ячейке всегда присутствует допустимая команда.
            }
            undoCommand = noCommand;
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)//нажатие кнопки на ON пульте
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void offButtonWasPushed(int slot)//нажатие кнопки на OFF пульте
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }
        public void undoButtonWasPushed()//нажатие кнопки отмены пульте
        {
            undoCommand.undo();
        }

        public String ToString()//переопределяем метод ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Пульт управления -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                + " " + offCommands[i].GetType().Name + "\n");
            }
            stringBuff.Append("Кнопка отмены: " + undoCommand.GetType().Name);
            return stringBuff.ToString();
        }
    }

    public class NoCommand : Command 
    {
        public void execute() { }
        public void undo() { }
    }
}
