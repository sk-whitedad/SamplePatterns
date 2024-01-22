using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //фабрика
    public class SimplePizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            return pizza;
        }


    }
}
