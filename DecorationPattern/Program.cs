using DecorationPattern.Beverages;
using DecorationPattern.ConcreteDecorators;

namespace DecorationPattern
{
    public class StarbuzzCoffee
    {
        public static void Main(String[] args)
        {
            Console.WriteLine($"Выберите кофе:");
            Console.WriteLine($"E - Espresso");
            Console.WriteLine($"D - DarkRoast");
            Console.WriteLine($"H - HouseBlend");
            var k = Console.ReadLine();
            Beverage beverage = GetPizza(k);//выбрали кофе

            Console.WriteLine($"Выберите дополнение:");
            Console.WriteLine($"M - Mocha");
            Console.WriteLine($"O - Milk");
            Console.WriteLine($"S - Soy");
            var d = Console.ReadLine();
            beverage = GetDecor(d, beverage);//выбрали дополнение

            Console.WriteLine($"Ваш выбор:");
            Console.WriteLine($"{beverage.description} $ {beverage.cost()}");

        }

        private static Beverage? GetPizza(string k) =>
        k.ToLower() switch
        {
            "e" => new Espresso(),
            "d" => new DarkRoast(),
            "h" => new HouseBlend(),
            _ => null
        };

        private static Beverage? GetDecor(string k, Beverage b) =>
        k.ToLower() switch
        {
            "m" => new Mocha(b),
            "o" => new Milk(b),
            "s" => new Soy(b),
            "mo" => new Mocha(new Milk(b)),
            "mos" => new Mocha(new Milk(new Soy(b))),
            _ => null
        };
    }
}