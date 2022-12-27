using Strategy.Flys;
using Strategy.Quacks;
namespace Strategy
{
    internal class DecoyDuck : Duck
    {
        //описываем тип манка
        public DecoyDuck()
        {
            //тут используем полиморфизм
            quackBehavior = new Quack();//определяем тип крякания (манок крякает)
            flyBehavior = new FlyNoWay();//определяем тип полета утки (не летает)
        }
        public override void display()
        {
            Console.WriteLine("Я простой манок");
        }
    }
}
