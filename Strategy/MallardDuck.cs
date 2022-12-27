using Strategy.Flys;
using Strategy.Quacks;

namespace Strategy
{
    //описываем тип настоящей утки
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            //тут используем полиморфизм
            quackBehavior = new Quack();//определяем тип крякания (настоящая утка крякает)
            flyBehavior = new FlyWithWings();//определяем тип полета утки (она летает)
        }
        public override void display()
        {
            Console.WriteLine("Я настоящая кряква");
        }
    }
}
