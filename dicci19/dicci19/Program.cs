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
                                Console.WriteLine("Ingrese la nota del estudiante");
                                double nota = double.Parse(Console.ReadLine());
                                Console.Clear();
                                if (nota >= 0 && nota <= 100)
                                {
                                    continuar = true;
                                    notas.Add(nombre, nota);
                                    Console.WriteLine("La nota se ha agregado correctamente\n");
                                }
                                else
                                {
                                    Console.WriteLine("Asegurese de ingresar una nota válida\n");
                                }
                            }
                        } while (continuar==false);
                        break;
                    case 2:
                        if (notas.Count == 0)
                        {
                            Console.WriteLine("No se ha ingresado ninguna nota");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Ingrese el nombre del estudiante cuya nota desea modificar");
                                string nombre = Console.ReadLine();
                                Console.Clear();
                                if (notas.ContainsKey(nombre))
                                {
                                    Console.WriteLine("Ingrese la nueva nota del estudiante");
                                    double nota = double.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if (nota >= 0 && nota <= 100)
                                    {
                                        notas[nombre] = nota;
                                        Console.WriteLine("La nota se ha modificado correctamente");
                                        continuar = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Asegurese de ingresar una nota válida");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("El nombre ingresado no existe\n");
                                }
                            } while (continuar==false);
                        }
                        break;
                    default:
                        Console.WriteLine("Asegurese de ingresar una opción válida");
                        break;
                }
            } while (opcion!=4);
        }
    }
}
