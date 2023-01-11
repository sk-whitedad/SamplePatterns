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
            Fan livingFan = new Fan("Вентилятор в гостиной");//создаем экземпляр вентилятора в гостиной
            Sound sound = new Sound();//создаем экземпляр музыки

            //создаем экземпляры команд света в гостиной
            LightHomeOnCommand livingLightHomeOn = new LightHomeOnCommand(livingRoomLight);
            LightHomeOffCommand livingLightHomeOff = new LightHomeOffCommand(livingRoomLight);
            
            //создаем экземпляры команд света в кухне
            LightHomeOnCommand kitchenLightHomeOn = new LightHomeOnCommand(kitchenLight);
            LightHomeOffCommand kitchenLightHomeOff = new LightHomeOffCommand(kitchenLight);
            
            //создаем экземпляры команд вентилятора гостиной
            CeilingFanHighCommand livingFanHigh = new CeilingFanHighCommand(livingFan);
            CeilingFanMediumCommand livingFanMedium = new CeilingFanMediumCommand(livingFan);
            CeilingFanLowCommand livingFanLow = new CeilingFanLowCommand(livingFan);
            FanOffCommand livingFanOff = new FanOffCommand(livingFan);


            SoundOnCommand soundOn = new SoundOnCommand(sound);
            SoundOffCommand soundOff = new SoundOffCommand(sound);

            //Готовые команды связываем c ячейками пульта.
            remoteControl.setCommand(0, livingLightHomeOn, livingLightHomeOff);
            remoteControl.setCommand(1, kitchenLightHomeOn, kitchenLightHomeOff);

            remoteControl.setCommand(2, livingFanHigh, livingFanOff);
            remoteControl.setCommand(3, livingFanMedium, livingFanOff);
            remoteControl.setCommand(4, livingFanLow, livingFanOff);

            remoteControl.setCommand(5, soundOn, soundOff);

            Console.WriteLine(remoteControl.ToString());
            
            
            
            //Имитация нажатия клавиш пульта
            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.undoButtonWasPushed();
            Console.WriteLine(remoteControl.ToString());
            remoteControl.onButtonWasPushed(2);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.offButtonWasPushed(3);
            Console.WriteLine(remoteControl.ToString());
            remoteControl.undoButtonWasPushed();
            remoteControl.onButtonWasPushed(4);
            remoteControl.offButtonWasPushed(4);
            remoteControl.onButtonWasPushed(5);
            remoteControl.offButtonWasPushed(5);


            //Реализация макрокоманды из созданных выше объектов и их команд
            Console.WriteLine("Реализация макрокоманды из созданных выше объектов и их команд");
            Command[] partyOn = { livingLightHomeOn, kitchenLightHomeOn, livingFanHigh, soundOn };
            Command[] partyOff = { livingLightHomeOff, kitchenLightHomeOff, livingFanOff, soundOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remoteControl.setCommand(6, partyOnMacro, partyOffMacro);
            remoteControl.onButtonWasPushed(6);

            remoteControl.offButtonWasPushed(6);
            remoteControl.undoButtonWasPushed();

        }

    }
}