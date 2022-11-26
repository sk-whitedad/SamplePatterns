﻿using FactorySample_1.Product;
using FactorySample_1.Develop;

namespace FactorySample_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО КирпичСтрой");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Частный застройщик");
            House house = dev.Create();

            Console.ReadLine();
        }
    }


}