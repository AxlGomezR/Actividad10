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
            for(int i =1; i<=3; i++)
            {
                Console.WriteLine($"Ingrese el carné del estudiante {i}");
                int carne = int.Parse(Console.ReadLine());
                if (estudiantes.ContainsKey(carne))
                {
                    Console.WriteLine("El carné ingresado ya existe");
                    i--;
                }
                else
                {

                }
            }
        }
    }
}
