namespace AdapterPattern
{
    public class Programm
    {
        static void Main(string[] s)
        {
            IDuck duck = new MallardDuck();
            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Индюк говорит...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("Утка говорит...");
            testDuck(duck);

            Console.WriteLine("Адаптированный индюк говорит...");
            testDuck(turkeyAdapter);

            static void testDuck(IDuck duck)
            {
                duck.quack();
                duck.fly();
            }
        }
    }
}