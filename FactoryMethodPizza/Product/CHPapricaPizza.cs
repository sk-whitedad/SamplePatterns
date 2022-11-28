namespace FactoryMethodPizza.Product
{
    internal class CHPapricaPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine($"Выпекаем пиццу 15 минут");
        }

        public override void Box()
        {
            Console.WriteLine($"Упаковываем в папричную коробку");
        }

        public override void Cut()
        {
            Console.WriteLine($"Нарезаем в виде перца");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Привет из Чикаго!");
            Console.WriteLine($"Добавляем паприку");
        }
    }
}
