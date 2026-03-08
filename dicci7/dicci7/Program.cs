using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> productos = new Dictionary<int,string>();
            productos.Add(1,"Pan");
            productos.Add(2, "Salchichas");
            productos.Add(3, "Agua");
            bool continuar = false;
            do
            {
                int clave;
                Console.WriteLine("Ingrese la clave que tendrá el nuevo producto");
                clave = int.Parse(Console.ReadLine());
                if (productos.ContainsKey(clave))
                {
                    Console.WriteLine("Ingrese una clave diferente a una ya existente");
                }
            } while (continuar==false);
        }
    }
}
