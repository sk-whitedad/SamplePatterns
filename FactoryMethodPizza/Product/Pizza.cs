using FactoryMethodPizza.Ingredients;

namespace FactoryMethodPizza.Product
{
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public string toString()
        {
            var str = "Тут описание заказанной пиццы";
            return str;
        }
        public void Bake()
        {
            Console.WriteLine($"Выпекаем пиццу 25 минут при температуре 350C");
        }

        public void Box()
        {
            Console.WriteLine($"Упаковываем в коробку");
        }

        public void Cut()
        {
            Console.WriteLine($"Нарезаем на 1000 мелких квадратиков");
        }

        public abstract void Prepare();

    }
}
