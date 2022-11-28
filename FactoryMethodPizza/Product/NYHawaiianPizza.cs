namespace FactoryMethodPizza.Product
{
    public class NYHawaiianPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Нью-Йорка!");
            Console.WriteLine($"Добавляем ананасы и манго");
        }
    }
}
