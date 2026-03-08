using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> productos = new Dictionary<int, string>();
            productos.Add(101, "Piña");
            productos.Add(102, "Sandia");
            productos.Add(103, "Pera");
            productos.Add(104, "Papaya");
            productos.Add(105, "Manzana");
            foreach (var item in productos)
            {
                Console.WriteLine($"Clave: {item.Key} - Nombre: {item.Value}");
            }
        }
    }
}
