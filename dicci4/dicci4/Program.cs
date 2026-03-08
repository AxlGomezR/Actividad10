using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> ciudades = new Dictionary<int,string>();
            ciudades.Add(1,"Ciudad de Guatemala");
            ciudades.Add(2, "New York");
            ciudades.Add(3,"Paris");
            ciudades.Add(4,"Buenos Aires");
            ciudades.Add(5,"Medellín");
            Console.WriteLine($"La cuarta ciudad es: {ciudades[4]}");
        }
    }
}
