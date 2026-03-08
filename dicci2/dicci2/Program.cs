using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> productos = new Dictionary<int,string>();
            productos.Add(101,"Manzanas");
            productos.Add(102, "Peras");
            productos.Add(103, "Uvas");
            Console.WriteLine("Los productos en la lista son:");
            Console.WriteLine(productos[101]);
            Console.WriteLine(productos[102]);
            Console.WriteLine(productos[103]);
        }
    }
}
