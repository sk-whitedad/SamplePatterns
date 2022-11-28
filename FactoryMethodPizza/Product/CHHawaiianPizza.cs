namespace FactoryMethodPizza.Product
{
    public class CHHawaiianPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine($"Привет из Чикаго!");
            Console.WriteLine($"Добавляем ананасы и манго");
        }
    }
}
