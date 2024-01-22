using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Product
{
    public class PepperoniPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("Запекаем с пепперони колбасками");
        }

        public override void box()
        {
            Console.WriteLine("Кладем в коробку с крутыми пепперонями");
        }

        public override void cut()
        {
            Console.WriteLine("Нарезаем по-пепперонийски");
        }

        public override void prepare()
        {
            Console.WriteLine("Начинаем приготовление пиццы пепперони:");
        }
    }
}
