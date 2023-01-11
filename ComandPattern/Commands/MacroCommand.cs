namespace CommandPattern.Commands
{
    public class MacroCommand: Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            //Берем массив команд и сохраняем их в объекте MacroCommand.
            this.commands = commands;
        }
        public void execute()
        {
            //При выполнении макрокоманды все эти команды будут последовательно выполнены.
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].undo();
            }
        }
    }
}
