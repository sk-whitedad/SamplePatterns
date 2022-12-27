namespace Strategy.Quacks
{
    internal class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            // Не издает звуков!
            Console.WriteLine("Молчу как рыба");
        }
    }
}
