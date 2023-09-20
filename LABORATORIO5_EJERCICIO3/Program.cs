using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO5_EJERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de notas: ");
            int notas = int.Parse(Console.ReadLine());

            float nota = 0;
            float promedio = 0f;

            for (int i = 1; i <= notas; i++)
            {
                Console.WriteLine("Ingrese la nota " + i + ":");
                int num = int.Parse(Console.ReadLine());

                promedio = promedio + num;
            }
            
            promedio = promedio / notas;
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}
