using Strategy.Flys;
using Strategy.Quacks;

namespace Strategy
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            //тут используем полиморфизм
            quackBehavior = new Quack();//определяем тип крякания (настоящая утка крякает)
            flyBehavior = new FlyWithWings();//определяем тип полета утки (она летает)
        }
        public override void display()
        {
            Console.WriteLine("Я настоящая красноголовая утка");
        }
    }
}
