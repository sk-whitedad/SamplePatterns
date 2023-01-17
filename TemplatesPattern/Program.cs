namespace TemplatesPattern
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите напиток:");
            Console.WriteLine("T - Чай");
            Console.WriteLine("C - Кофе");
            var key = Console.ReadLine();
            if (key == "T")
            {
                Tea tea= new Tea();
                tea.prepareRecipe();
            }
            if (key == "C")
            {
                Cofee cofee= new Cofee();
                cofee.prepareRecipe();
            }

        }
    }
}
