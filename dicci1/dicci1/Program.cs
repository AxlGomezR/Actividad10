using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> estudiantes = new Dictionary<int, string>();
            estudiantes.Add(1, "Juan");
            estudiantes.Add(2, "Carmen");
            Console.WriteLine($"nombre del estudiante: {estudiantes[1]}");
        }
    }
}
