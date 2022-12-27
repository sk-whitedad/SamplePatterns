namespace Strategy.Flys
{
    internal class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Я не умею летать!");
        }
    }
}
