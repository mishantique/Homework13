using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Building building = new Building("Кронверкский 49", 150, 75, 30);
            string result = building.Print();
            Console.WriteLine("'Print' для Building");
            Console.WriteLine(result);
            Console.WriteLine();

            MultiBuilding multibuilding = new MultiBuilding("Кронверкский 49", 150, 75, 30, 4);
            result = multibuilding.Print();
            Console.WriteLine("'Print' для MultiBuilding");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
