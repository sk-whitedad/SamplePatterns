namespace Strategy.Quacks
{
    internal class Squeak : QuackBehavior
    {
        public void quack()
        {
            // Резиновая утка пищит
            Console.WriteLine("Пи-пи-пи!");
        }
    }
}
