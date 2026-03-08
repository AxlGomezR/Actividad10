using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicci10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> inventario = new Dictionary<int,string>();
            inventario.Add(101, "Alambre");
            inventario.Add(102, "Pegamento");
            inventario.Add(103, "Martillo");
            bool continuar = false;
            do
            {
                Console.WriteLine("Ingrese la clave del producto que desea eliminar");
                int clave = int.Parse(Console.ReadLine());
                Console.Clear();
                if (inventario.ContainsKey(clave))
                {
                    Console.WriteLine($"Se ha eliminado el producto {inventario[clave]}");
                    inventario.Remove(clave);
                    continuar = true;
                }
                else
                {
                    Console.WriteLine("La clave ingresada no existe");
                }
            } while (continuar==false);
        }
    }
}
