using Strategy.Flys;
using Strategy.Quacks;

namespace Strategy
{
    internal class RubberDuck: Duck
    {
        public RubberDuck()
        {
            //тут используем полиморфизм
            quackBehavior = new MuteQuack();//определяем тип крякания (не крякает)
            flyBehavior = new FlyNoWay();//определяем тип полета утки (она не летает)
        }
        public override void display()
        {
            Console.WriteLine("Я простая резиновая утка");
        }
    }
}
