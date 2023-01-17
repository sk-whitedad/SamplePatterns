namespace TemplatesPattern
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }
        //абстрактные методы которые будут определены в конкретных классах
        public abstract void brew();
        public abstract void addCondiments();

        //общие методы
        void boilWater()
        {
            // реализация
            Console.WriteLine("Вскипятить воду");
        }
        public void pourInCup()
        {
            //реализация
            Console.WriteLine("Перелить в чашку");
        }

    }
}
