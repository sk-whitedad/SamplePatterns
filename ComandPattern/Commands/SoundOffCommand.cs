using CommandPattern.Devices;

namespace CommandPattern.Commands
{
    public class SoundOffCommand : Command
    {
        Sound sound;
        public SoundOffCommand(Sound sound)
        {
            this.sound = sound;
        }
        public void execute()
        {
            sound.Off();
        }
        public void undo()
        {
            sound.On();
        }
    }
}
