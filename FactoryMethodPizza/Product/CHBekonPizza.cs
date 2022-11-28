namespace FactoryMethodPizza.Product
{
    internal class CHBekonPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine($"Выпекаем пиццу 30 минут");
        }

        public override void Box()
        {
            Console.WriteLine($"Упаковываем в беконовую коробку");
        }

        public override void Cut()
        {
            Console.WriteLine($"Нарезаем по беконовски");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Привет из Чикаго!");
            Console.WriteLine($"Добавляем бекон");
        }
    }
}
