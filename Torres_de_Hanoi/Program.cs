using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
       static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Introduzca numero de discos: ");
            num = Convert.ToInt32(Console.ReadLine());

            Pila INI = new Pila(num, "ini");
            Pila AUX = new Pila("aux");
            Pila FIN = new Pila("fin");

            int m = Hanoi.iterativo(num, INI, FIN, AUX);
            Console.WriteLine("Número de movimientos: " + m);


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
