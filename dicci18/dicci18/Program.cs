using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese el nombre de usuario");
                string usuario = Console.ReadLine();
                Console.Clear();
                if (usuarios.ContainsKey(usuario))
                {
                    Console.WriteLine("El usuario ingresado ya existe\n");
                }
                else
                {
                    Console.WriteLine("Ingrese la contraseña de su usuario");
                    string contra = Console.ReadLine();
                    Console.Clear();
                    usuarios.Add(usuario, contra);
                    Console.WriteLine("Se ha registrado correctamente\n");
                }
            } while (continuar==false);
        }
    }
}
