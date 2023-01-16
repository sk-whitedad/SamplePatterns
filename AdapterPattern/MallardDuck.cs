namespace AdapterPattern
{
    public class MallardDuck: IDuck
    {
        public void quack()
        {
            Console.WriteLine("Кря-кря");
        }
        public void fly()
        {
            Console.WriteLine("Я умею летать как любая утка!");
        }
    }
}
