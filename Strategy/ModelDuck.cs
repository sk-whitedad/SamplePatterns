using Strategy.Flys;
using Strategy.Quacks;

namespace Strategy
{
    internal class ModelDuck: Duck
    {
        //описываем тип утки приманки
        public ModelDuck()
        {
            //тут используем полиморфизм
            quackBehavior = new Quack();//определяем тип крякания (утка приманка крякает)
            flyBehavior = new FlyNoWay();//определяем тип полета утки (утка приманка не летает)
        }
        public override void display()
        {
            Console.WriteLine("Я утка приманка");
        }
    }
}
