using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> notas = new Dictionary<string,int>();
            notas.Add("Estudiante1",70);
            notas.Add("Estudiante2", 80);
            notas.Add("Estudiante3", 64);
            notas.Add("Estudiante4", 100);
            int sumaNotas=0;
            foreach (var item in notas) {
                sumaNotas += item.Value;
            }
            sumaNotas /= notas.Count;
            Console.WriteLine($"El promedio de las notas es: {sumaNotas}");
        }
    }
}
