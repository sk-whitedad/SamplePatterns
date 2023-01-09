using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class SoundOnCommand: Command
    {
        Sound sound;
        public SoundOnCommand(Sound sound)
        {
            this.sound = sound;
        }
        public void execute()
        {
            sound.On();
        }
    }
}
