namespace TemplatesPattern
{
    public class Cofee : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Добавляем молоко и сахар");
        }

        public override void brew()
        {
            Console.WriteLine("Завариваем кофе");
        }
    }
}
