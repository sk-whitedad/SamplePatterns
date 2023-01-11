using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class LightHomeOnCommand : Command
    {
        LightHome lightHome;
        public LightHomeOnCommand(LightHome lightHome)
        {
            this.lightHome = lightHome;
        }
        public void execute()
        {
            lightHome.On();
        }
        public void undo()
        {
            lightHome.Off();
        }
    }
}
