using Strategy.Flys;

namespace Strategy
{
    class Programm
    {
        static void Main()
        {
            Duck mallard = new MallardDuck();//настоящая утка
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();//утка-приманка
            model.performFly();//тут утка еще не умеет летать
            //Вызываем set-метод, унаследованный классом ModelDuck, и... 
            //утка-приманка вдруг взлетает на реактивном двигателе!
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}