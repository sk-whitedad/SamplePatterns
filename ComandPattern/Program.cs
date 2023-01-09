using CommandPattern.Commands;
using CommandPattern.Devices;

namespace CommandPattern
{
    public class RemoteLoad
    {
        private static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();//создаем экземпляр пульта управления
            LightHome livingRoomLight = new LightHome();//создаем экземпляр света в гостиной
            LightHome kitchenLight = new LightHome();//создаем экземпляр света в кухне
            Fan livingFun = new Fan();//создаем экземпляр вентилятора в гостиной
            Fan kitchenFun = new Fan();//создаем экземпляр вентилятора в кухне
            Sound sound = new Sound();//создаем экземпляр музыки

            //создаем экземпляры команд
            LightHomeOnCommand livingLightHomeOn = new LightHomeOnCommand(livingRoomLight);
            LightHomeOffCommand livingLightHomeOff = new LightHomeOffCommand(livingRoomLight);
            LightHomeOnCommand kitchenLightHomeOn = new LightHomeOnCommand(kitchenLight);
            LightHomeOffCommand kitchenLightHomeOff = new LightHomeOffCommand(kitchenLight);

            FanOnCommand livingFanOn = new FanOnCommand(kitchenFun);
            FanOffCommand livingFanOff = new FanOffCommand(kitchenFun);
            FanOnCommand kitchenFanOn = new FanOnCommand(kitchenFun);
            FanOffCommand kitchenFanOff = new FanOffCommand(kitchenFun);

            SoundOnCommand soundOn = new SoundOnCommand(sound);
            SoundOffCommand soundOff = new SoundOffCommand(sound);

            //Готовые команды связываем c ячейками пульта.
            remoteControl.setCommand(0, livingLightHomeOn, livingLightHomeOff);
            remoteControl.setCommand(1, kitchenLightHomeOn, kitchenLightHomeOff);
            remoteControl.setCommand(2, livingFanOn, livingFanOff);
            remoteControl.setCommand(3, kitchenFanOn, kitchenFanOff);
            remoteControl.setCommand(4, soundOn, soundOff);

            Console.WriteLine(remoteControl.ToString());

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);
            remoteControl.onButtonWasPushed(4);
            remoteControl.offButtonWasPushed(4);

        }

    }
}