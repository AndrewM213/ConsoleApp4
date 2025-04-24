using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class cola
    {
        nodo Primero { get; set; }
        public void AGREGAR_ULTIMO(string cadena)
        {         
            nodo nuevo = new nodo(cadena);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                nodo temp = this.Primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void ELIMINAR_PRIMERO()
        {
            if (this.Primero == null)
            {
                Console.WriteLine("no hay elementos en la cola");
               
            }
            else
            {
                this.Primero = Primero.sig;
            }
        }
        public override string ToString()
        {
            string cola = "";
            nodo tmp = this.Primero;
            while (tmp != null)
            {
                cola += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return cola;

        }
    }
}
