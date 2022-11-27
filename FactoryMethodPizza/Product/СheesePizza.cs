namespace FactoryMethodPizza.Product
{
    public class СheesePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine($"Выпекаем пиццу 25 минут");
        }

        public override void Box()
        {
            Console.WriteLine($"Упаковываем в сырную коробку");
        }

        public override void Cut()
        {
            Console.WriteLine($"Нарезаем полумесяцами");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Добавляем сыр");
        }
    }
}
