namespace SimpleFactory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Введите название пиццы:\n" +
                $"Пепперони - \"pepperoni\"\n" +
                $"Сырная - \"cheese\"\n" +
                $"Греческая - \"greek\"\n");
            var str = Console.ReadLine();
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            store.orderPizza(str);


        }
    }
}
