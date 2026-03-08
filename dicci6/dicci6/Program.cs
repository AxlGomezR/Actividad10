using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            estudiantes.Add(1,"Jill");
            estudiantes.Add(2, "Rebeca");
            estudiantes.Add(3, "Chris");
            Console.WriteLine($"Se eliminará al estudiante: {estudiantes[2]}");
            estudiantes.Remove(2);
            Console.WriteLine("Se ha removido correctamente");
        }
    }
}
