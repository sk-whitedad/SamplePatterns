using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class CheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Запекаем в сырном соусе");
        }

        public override void box()
        {
            Console.WriteLine("Кладем в коробку с моцарелой");
        }

        public override void cut()
        {
            Console.WriteLine("Нарезаем по-сырному");
        }

        public override void prepare()
        {
            Console.WriteLine("Начинаем приготовление сырной пиццы:");
        }
    }
}
