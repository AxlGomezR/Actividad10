using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> usuarios = new Dictionary<string,string>();
            usuarios.Add("Javier1","Contra123");
            usuarios.Add("Sofi3", "Contraseña");
            usuarios.Add("Diego4", "123contra");
            Console.WriteLine($"La contraseña del usuario Sofi3 es: {usuarios["Sofi3"]}");
        }
    }
}
