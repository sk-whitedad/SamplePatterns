namespace FactoryMethodPizza.Product
{
    internal class NYBekonPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Нью-Йорка!");
            Console.WriteLine($"Добавляем бекон");
        }
    }
}
