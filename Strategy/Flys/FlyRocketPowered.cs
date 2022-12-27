namespace Strategy.Flys
{
    internal class FlyRocketPowered: FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Я летаю как ракета!");
        }
    }
}
