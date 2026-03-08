using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> notas = new Dictionary<string,double>();
            int opcion;
            do
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1) Agregar nota");
                Console.WriteLine("2) Modificar nota");
                Console.WriteLine("3) Mostrar notas");
                Console.WriteLine("4) Salir");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion!=4);
        }
    }
}
