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
            bool continuar;
            do
            {
                Console.WriteLine("Selecicone una opción");
                Console.WriteLine("1) Agregar producto");
                Console.WriteLine("2) Eliminar producto");
                Console.WriteLine("3) Ver productos");
                Console.WriteLine("4) Salir");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                continuar = false;
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese la clave del producto");
                            int clave = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (inventario.ContainsKey(clave))
                            {
                                Console.WriteLine("La clave ingresada ya existe");
                            }
                            else
                            {

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
