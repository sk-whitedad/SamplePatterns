using FactoryMethodPizza.Factory;
using FactoryMethodPizza.Product;

namespace FactoryMethodPizza
{
    static class Programm
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Выберите пожалуйста пиццу:");
            Console.WriteLine($"> Сырная - C <");
            Console.WriteLine($"> Паприка - P <");
            Console.WriteLine($"> Гавайская - H <");
            Console.WriteLine($"> Бекон - B <");
            var pizzaType = Console.ReadLine();
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);

            Pizza youPizza = pizzaStore.orderPizza(pizzaType);
            Console.WriteLine($"Спасибо за заказ! Ждем Вас снова");

        }
    }
}

