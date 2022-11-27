namespace FactoryMethodPizza.Product
{
    internal class HawaiianPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine($"Выпекаем пиццу 20 минут.");
        }

        public override void Box()
        {
            Console.WriteLine($"Упаковываем в гавайскую коробку");
        }

        public override void Cut()
        {
            Console.WriteLine($"Нарезаем в виде пальмы");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Добавляем ананасы и манго");
        }
    }
}
