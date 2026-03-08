using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> inventario = new Dictionary<int,string>();
            int opcion;
            do
            {
                Console.WriteLine("Selecicone una opción");
                Console.WriteLine("1) Agregar producto");
                Console.WriteLine("2) Eliminar producto");
                Console.WriteLine("3) Ver productos");
                Console.WriteLine("4) Salir");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion!=4);
        }
    }
}
