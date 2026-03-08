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
                                Console.WriteLine("Ingrese el nombre del producto");
                                string nombre = Console.ReadLine();
                                Console.Clear();
                                inventario.Add(clave,nombre);
                                Console.WriteLine("El producto se ha añadido correctamente\n");
                                continuar = true;
                            }
                        } while (continuar==false);
                        break;
                    case 2:
                        if (inventario.Count == 0)
                        {
                            Console.WriteLine("No se ha ingresado ningún producto\n");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese la clave del producto que desea eliminar");
                            int clave = int.Parse(Console.ReadLine());
                            if (inventario.ContainsKey(clave))
                            {
                                Console.WriteLine($"Se ha eliminado el producto {inventario[clave]}\n");
                                inventario.Remove(clave);
                            }
                            else
                            {
                                Console.WriteLine("La clave ingresada no existe\n");
                            }
                        }
                        break;
                    case 3:
                        if (inventario.Count == 0)
                        {
                            Console.WriteLine("No se ha ingresado ningún producto\n");
                        }
                        else
                        {
                            Console.WriteLine("Productos ingresados:");
                            foreach (var item in inventario)
                            {
                                Console.WriteLine(item.Value);
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Asegurese de ingresar una opción válida");
                        break;
                }
            } while (opcion!=4);
        }
    }
}
