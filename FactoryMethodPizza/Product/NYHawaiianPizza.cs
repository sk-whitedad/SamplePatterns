namespace FactoryMethodPizza.Product
{
    public class NYHawaiianPizza : Pizza
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
            Console.WriteLine($"Привет из Нью-Йорка!");
            Console.WriteLine($"Добавляем ананасы и манго");
        }
    }
}
