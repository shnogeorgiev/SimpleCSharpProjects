using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___02.Laptop_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop testOne = new Laptop("LAPTOP MODEL", 25.25, "BATTERY VALUE", "BATTERY LIFESPAN");
            Console.WriteLine(testOne);
            Laptop testTwo = new Laptop("LAPTOP MODEL", 11.11, "BATTERY VALUE", "BATTERY LIFESPAN", "MANUFACTURER", "PROCESSOR");
            Console.WriteLine(testTwo);
        }
    }
}
