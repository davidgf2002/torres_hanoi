using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        private static int num_movimientos;
        private static Pila INI, FIN, AUX;


        private static void mover_disco(Pila a, Pila b)
        {
            if(!solucion()) //solucion() == false
            { 
                // a -> b
                if(!a.isEmpty())
                {
                    if(b.isEmpty())
                    {
                        b.push( a.pop() );
                        num_movimientos ++;
                        Console.WriteLine(a.Nombre + "-" +b.Top.tamaño + "->" + b.Nombre);
                    }
                    else if(a.Top.tamaño < b.Top.tamaño)
                    {
                        b.push( a.pop() );
                        num_movimientos ++;
                        Console.WriteLine(a.Nombre + "-" + b.Top.tamaño + "->" + b.Nombre);
                    }
                    else
                    {
                        a.push( b.pop() );
                        num_movimientos ++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.tamaño + "->" + a.Nombre);
                    }
                }
                else //a.isEmpty() == true
                {
                    if(!b.isEmpty())
                    {
                        a.push( b.pop() );
                        num_movimientos ++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.tamaño + "->" + a.Nombre);
                    }
                }
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
