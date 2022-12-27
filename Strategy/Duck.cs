using Strategy.Flys;
using Strategy.Quacks;

namespace Strategy
{
    internal abstract class Duck
    {
        public FlyBehavior flyBehavior { get; set; }
        public QuackBehavior quackBehavior { get; set; }

        public void swim()
        {
            Console.WriteLine("Все утки плавают, даже манки!");
        }
        public abstract void display();

        //Делегирование операции классам поведения.
        public void performQuack()
        {
            quackBehavior.quack();
        }

        //Делегирование операции классам поведения.
        public void performFly()
        {
            flyBehavior.fly();
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
