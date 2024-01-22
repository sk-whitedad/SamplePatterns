using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class GreekPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Запекаем на греческом олимпийском огне");
        }

        public override void box()
        {
            Console.WriteLine("Кладем в коробку с греческими богинями");
        }

        public override void cut()
        {
            Console.WriteLine("Нарезаем по-гречески");
        }

        public override void prepare()
        {
            Console.WriteLine("Начинаем приготовление греческой пиццы:");
        }
    }
}
