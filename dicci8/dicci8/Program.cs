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
                if (empleados.ContainsKey(id))
                {
                    Console.WriteLine("Ingrese el nuevo nombre");
                    string nombre = Console.ReadLine();
                    empleados[id] = nombre;
                    Console.WriteLine("El nombre se ha modificado correctamente");
                    Console.WriteLine($"El nuevo nombre es {empleados[id]}");
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("El ID ingresada no existe en el diccionario");
                }
            } while (continuar==false);
        }
    }
}
