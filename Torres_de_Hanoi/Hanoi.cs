using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        private static int num_discos;
        private static int num_movimientos;

        private static Pila INI, FIN, AUX;


        private static void mover_disco(Pila a, Pila b)
        {
            if(!pruebaAutomatica()) //solucion() == false
            { 
                // mover a -> b
                if(a.isEmpty() == false) //"a" no está vacío
                {
                    if(b.isEmpty() == true) //"b" está vacío
                    {
                        b.push( a.pop() ); //Se coge el disco de "a" y se añade a "b"
                        num_movimientos ++;
                        Console.WriteLine(a.Nombre + "-" +b.Top.tamaño + "->" + b.Nombre);
                    }
                    else if(a.Top.tamaño < b.Top.tamaño) //Si tamaño disco arriba "a" menor que el de "b"
                    {
                        b.push( a.pop() ); //Se mueve de "a" a "b"
                        num_movimientos ++;
                        Console.WriteLine(a.Nombre + "-" + b.Top.tamaño + "->" + b.Nombre);
                    }
                    else //Si tamaño disco arriba "b" menor que el de "a"
                    {
                        a.push( b.pop() ); //Se mueve de "b" a "a" 
                        num_movimientos ++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.tamaño + "->" + a.Nombre);
                    }
                }
                else //"a" está vacío
                {
                    if(b.isEmpty() == false) //"b" no está vacío
                    {
                        a.push( b.pop() ); //Se mueve de "b" a "a"
                        num_movimientos ++;
                        Console.WriteLine(b.Nombre + "-" + a.Top.tamaño + "->" + a.Nombre);
                    }
                }
            }
        }



        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            INI = ini;
            FIN = fin;
            AUX = aux;

            num_movimientos = 0;
            num_discos = n;

            if(n % 2 != 0) //El num de discos es impar
            {
                while(pruebaAutomatica() == false) //Mientras la pila final no tenga n discos
                {
                    mover_disco(ini, fin);
                    mover_disco(ini,aux);
                    mover_disco(aux, fin);
                }
            }
            else //El num de discos es par
            {
                while(pruebaAutomatica() == false) //Mientras la pila final no tenga n discos
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
            }
            return num_movimientos;
        }



        private static bool pruebaAutomatica()
        {
            if( (FIN.Size == num_discos) && (INI.Size == 0) )
            {
                return true;
            }
            return false;
        }

    }
}
