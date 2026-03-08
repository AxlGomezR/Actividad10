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
            bool continuar;
            do
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1) Agregar estudiante");
                Console.WriteLine("2) Mostrar estudiantes");
                Console.WriteLine("3) Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                continuar = false;
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese la clave del estudiante");
                            int clave = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (estudiantes.ContainsKey(clave))
                            {
                                Console.WriteLine("Asegurese de ingresar una clave que no haya sido ingresada");
                            }
                            else
                            {

                            }
                        } while (continuar == false);
                        break;
                    default:
                        Console.WriteLine("Asegurese de ingresar una opción válida");
                        break;
                }
            } while (opcion!=3);
        }
    }
}
