using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Zdanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Building = new Building("ул. Ленина, д. 6", -36, 12, 6);
            Console.WriteLine(Building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("ул. Горького, д. 150", 48, 24, 15, 5);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }   
}
