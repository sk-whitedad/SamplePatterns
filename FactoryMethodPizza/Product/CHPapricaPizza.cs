namespace FactoryMethodPizza.Product
{
    internal class CHPapricaPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Чикаго!");
            Console.WriteLine($"Добавляем паприку");
        }
    }
}
