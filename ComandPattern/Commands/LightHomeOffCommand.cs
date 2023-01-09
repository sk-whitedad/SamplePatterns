using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class LightHomeOffCommand: Command
    {
        LightHome lightHome;
        public LightHomeOffCommand(LightHome lightHome)
        {
            this.lightHome = lightHome;
        }
        public void execute()
        {
            lightHome.Off();
        }
    }
}
