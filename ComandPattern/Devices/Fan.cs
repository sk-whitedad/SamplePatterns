namespace CommandPattern.Devices
{
    public class Fan
    {
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        String location;
        int speed;

        public Fan(String location)
        {
            this.location = location;
            speed = OFF;
        }

        public void high()
        {
            speed = HIGH;
            Console.WriteLine("Вентилятор включен: Высокая скорость");
        }
        public void medium()
        {
            speed = MEDIUM;
            Console.WriteLine("Вентилятор включен: Средняя скорость");
        }
        public void low()
        {
            speed = LOW;
            Console.WriteLine("Вентилятор включен: Низкая скорость");
        }
        public void off()
        {
            speed = OFF;
            Console.WriteLine("Вентилятор выключен");
        }
        public int getSpeed()//получение текущей скорости
        {
            return speed;
        }
    }
}
