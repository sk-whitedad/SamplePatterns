using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class FanOffCommand: Command
    {
        Fan fan;
        public FanOffCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void execute()
        {
            fan.Off();
        }
    }
}
