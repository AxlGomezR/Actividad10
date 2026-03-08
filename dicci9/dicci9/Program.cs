using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> notas = new Dictionary<string, int>();
            notas.Add("Jimena",65);
            notas.Add("Julia", 70);
            notas.Add("Pedro", 55);
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese el nombre del estudiante para desplegar su nota");
                string nombre = Console.ReadLine();
                Console.Clear();

            } while (continuar==false);
        }
    }
}
