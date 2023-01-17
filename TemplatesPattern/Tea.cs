namespace TemplatesPattern
{
    public class Tea : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Добавляем лимон");
        }

        public override void brew()
        {
            Console.WriteLine("Завариваем чай");
        }
    }
}
