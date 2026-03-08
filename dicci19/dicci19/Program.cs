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
            bool continuar;
            int opcion;
            do
            {
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("1) Agregar nota");
                Console.WriteLine("2) Modificar nota");
                Console.WriteLine("3) Mostrar notas");
                Console.WriteLine("4) Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                continuar = false;
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese el nombre del estudiante");
                            string nombre = Console.ReadLine();
                            Console.Clear();
                            if (notas.ContainsKey(nombre))
                            {
                                Console.WriteLine("Este estudiante ya ha sido ingresado\n");
                            }
                            else
                            {
                                continuar = true;
                                Console.WriteLine("Ingrese la nota del estudiante");
                            }
                        } while (continuar==false);
                        break;
                    default:
                        Console.WriteLine("Asegurese de ingresar una opción válida");
                        break;
                }
            } while (opcion!=4);
        }
    }
}
