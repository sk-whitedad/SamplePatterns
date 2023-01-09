namespace CommandPattern.Devices
{
    public class Fan
    {
        public void On()
        {
            Console.WriteLine("Вентилятор включен");
        }
        public void Off()
        {
            Console.WriteLine("Вентилятор выключен");
        }
        public void SetPower(int power)
        {
            Console.WriteLine($"Мощность вентилятора {power}%") ;
        }
    }
}
