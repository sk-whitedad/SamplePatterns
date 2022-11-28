namespace FactoryMethodPizza.Product
{
    public class CHСheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Нью-Йорка!");
            Console.WriteLine($"Добавляем сыр");
        }
    }
}
