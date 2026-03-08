using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> empleados = new Dictionary<int,string>();
            empleados.Add(101, "Jorge");
            empleados.Add(102, "Jaime");
            empleados.Add(103, "Ana");
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese la ID del empleado que desea modificar");
                int id = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (continuar==false);
        }
    }
}
