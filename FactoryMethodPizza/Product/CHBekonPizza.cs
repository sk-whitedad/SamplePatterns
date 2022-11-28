namespace FactoryMethodPizza.Product
{
    internal class CHBekonPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Чикаго!");
            Console.WriteLine($"Добавляем бекон");
        }
    }
}
