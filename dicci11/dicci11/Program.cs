using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> estudiantes = new Dictionary<int,string>();
            estudiantes.Add(101,"Maria");
            estudiantes.Add(102, "Rene");
            estudiantes.Add(103, "Javier");
            estudiantes.Add(104, "Diego");
            estudiantes.Add(105, "Luisa");
            foreach (var item in estudiantes)
            {
                Console.WriteLine($"Clave: {item.Key} - Nombre: {item.Value}");
            }
        }
    }
}
