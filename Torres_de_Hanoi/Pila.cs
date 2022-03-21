using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
class Pila
    {
        public string Nombre { get; set; }

        public List<Disco> Elementos { get; set; }


        public int Size 
        { get
            {
                return Elementos.Count;
            }
        }

        public Disco Top 
        { get 
            {
                if(isEmpty() == false)
                {
                    return Elementos[Size - 1];
                }
                return null;
            }
        }


        /* Constructores */
        public Pila(string n)
        {
            Elementos = new List <Disco> ();
            Nombre = n;

        }

        public Pila(int cantidad, string n)
        {
            Elementos = new List<Disco> ();
            Nombre = n;

            for(int i=cantidad; i>0; i--)
            {
                //Se crea un disco para añadir a la pila
                Disco nuevo = new Disco();
                nuevo.tamaño = i;

                //Se añade el disco a la pila
                push(nuevo);
            }
        }
        /* -------------------- */

        public void push(Disco d)
        {
            Elementos.Add(d);
        }


        public Disco pop()
        {
            //Guardamos disco de arriba para no "perderlo"
            Disco d = Top;

            //Eliminar disco
            Elementos.RemoveAt(Size - 1);

            return d;
        }

        public bool isEmpty()
        {
           if(Size == 0)
            {
                return true;
            }
           return false;
        }
    }

}
