using FactoryMethodPizza.Factory;
using FactoryMethodPizza.Product;

namespace FactoryMethodPizza
{
    static class Programm
    {
        static void Main()
        {
            PizzaStore pizzaStore;
            Console.WriteLine("Здравствуйте! Выберите пиццерию:");
            Console.WriteLine($"> C - Чикаго <");
            Console.WriteLine($"> N - Нью-Йорк <");
            var storeType = Console.ReadLine();
            
            if (storeType == "C")
            {
                pizzaStore = new CHPizzaStore();
            }
            else if (storeType == "N")
            {
                pizzaStore = new NYPizzaStore();
            }else pizzaStore = null;

            Console.WriteLine("Выберите пожалуйста пиццу:");
            Console.WriteLine($"> Сырная - C <");
            Console.WriteLine($"> Паприка - P <");
            Console.WriteLine($"> Гавайская - H <");
            Console.WriteLine($"> Бекон - B <");
            var pizzaType = Console.ReadLine();
            
            if (pizzaStore != null)
            {
                Pizza youPizza = pizzaStore.orderPizza(pizzaType);
                Console.WriteLine($"Спасибо за заказ! Ждем Вас снова");
            }

        }
    }
}

