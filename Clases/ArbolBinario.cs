using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ArbolBinario
    {
        public Nodo raiz;

        public void insertar(ref Nodo raiz, int dato)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = dato;
                raiz = nuevo;
                Console.WriteLine("nodo insertado");
            }
            else
            {
                if (dato < raiz.dato)//izq
                {
                    insertar(ref raiz.izquierda, dato);
                }
                else if (dato > raiz.dato)//der
                {
                    insertar(ref raiz.derecha, dato);
                }
                else//iguales
                {
                    Console.WriteLine("El nodo ya existe");
                }
            }
        }
    }
}
