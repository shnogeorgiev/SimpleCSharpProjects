using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___03.PC_Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Component> componentsList = new List<Component>();
            Computer computer;
            Console.WriteLine("How many computers will you build?");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                
                Console.WriteLine("Computer #{0} name: ", i);
                string name = Console.ReadLine();

                Console.WriteLine("Will there be components? Y / N");
                if (Console.ReadLine().Equals("Y")) 
                {
                    Console.WriteLine("Select 3 Components: ");
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.WriteLine("Component #{0} Name ", j);
                        string componentName = Console.ReadLine();
                        Console.WriteLine("Component #{0} Price: ", j);
                        double componentPrice = double.Parse(Console.ReadLine());

                        Component component = new Component(componentName, componentPrice);
                        componentsList.Add(component);
                    }
                    computer = new Computer(name, componentsList[0], componentsList[1], componentsList[2]);
                }
                else
                {
                    computer = new Computer(name);
                }
                Console.WriteLine(computer.Output);
            }
        }
    }
}
