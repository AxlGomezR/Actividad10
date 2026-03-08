using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, (string, int, string)> estudiantes = new Dictionary<int, (string, int, string)>();
            bool continuar;
            for(int i =1; i<=3; i++)
            {
                Console.WriteLine($"Ingrese el carné del estudiante {i}");
                int carne = int.Parse(Console.ReadLine());
                if (estudiantes.ContainsKey(carne))
                {
                    Console.WriteLine("El carné ingresado ya existe\n");
                    i--;
                }
                else
                {
                    Console.WriteLine("Ingrese el nombre del estudiante");
                    string nombre = Console.ReadLine();
                    int edad;
                    continuar = false;
                    do
                    {
                        Console.WriteLine("\nIngrese la edad del estudiante");
                        edad = int.Parse(Console.ReadLine());
                        if (edad >= 0)
                        {
                            continuar = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese una opción válida\n");
                        }
                    } while (continuar==false);
                    Console.WriteLine("\nIngrese la carrera del estudiante");
                    string carrera = Console.ReadLine();
                    estudiantes.Add(carne, (nombre, edad, carrera));
                }
            }
        }
    }
}
