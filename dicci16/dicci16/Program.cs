using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> estudiantes = new Dictionary<int,string>();
            int opcion;
            do
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1) Agregar estudiante");
                Console.WriteLine("2) Mostrar estudiantes");
                Console.WriteLine("3) Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:

                        break;
                    default:
                        Console.WriteLine("Asegurese de ingresar una opción válida");
                        break;
                }
            } while (opcion!=3);
        }
    }
}
