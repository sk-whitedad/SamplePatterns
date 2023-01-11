using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class CeilingFanMediumCommand: Command
    {
        Fan fan;
        int prevSpeed;

        public CeilingFanMediumCommand(Fan fan)
        {
            this.fan = fan;
        }
        public void execute()
        {
            prevSpeed = fan.getSpeed();
            fan.medium();
        }
        public void undo()
        {
            if (prevSpeed == Fan.HIGH)
            {
                fan.high();
            }
            else if (prevSpeed == Fan.MEDIUM)
            {
                fan.medium();
            }
            else if (prevSpeed == Fan.LOW)
            {
                fan.low();
            }
            else if (prevSpeed == Fan.OFF)
            {
                fan.off();
            }
        }
    }
}
