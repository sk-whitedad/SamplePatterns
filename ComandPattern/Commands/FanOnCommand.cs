using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class FanOnCommand: Command

    {
        Fan fan;
        public FanOnCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void execute()
        {
            fan.SetPower(75);
            fan.On();
        }
    }
}
