using System.Text;

namespace CommandPattern
{
    //реализация пульта управления
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
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
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)//нажатие кнопки на ON пульте
        {
            onCommands[slot].execute();
        }
        public void offButtonWasPushed(int slot)//нажатие кнопки на OFF пульте
        {
            offCommands[slot].execute();
        }

        public String ToString()//переопределяем метод ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                + " " + offCommands[i].GetType().Name + "\n");
            }
            return stringBuff.ToString();
        }
    }

    public class NoCommand : Command 
    {
        public void execute() { }
    }
}
