namespace FactoryMethodPizza.Product
{
    internal class NYPapricaPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Нью-Йорка!");
            Console.WriteLine($"Добавляем паприку");
        }
    }
}
