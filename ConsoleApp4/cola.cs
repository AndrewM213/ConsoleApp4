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
        public void enqueue(string cadena)
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
        public void dequeue()
        {
            if (this.Primero == null)
            {
                Console.WriteLine("no hay elementos en la cola");
               
            }
            else if(this.Primero.sig == null)
            {
                this.Primero = null;
            }
            else
            {
                this.Primero = Primero.sig;
            }
        }
        public string front()
        {
            string primer = "";
            
            if (this.Primero == null)
            {
                Console.WriteLine("no existen valores");
                
            }
            else
            {
                nodo tmp = this.Primero;
                primer = tmp.Dato;

            }
            return primer;
        }
        public int Size()
        {
            if (this.Primero == null)
            {
                return 0;
            }
            else
            {
                int cont = 0;
                nodo tmp = this.Primero;
                while(tmp != null)
                {
                    cont++;
                    tmp = tmp.sig; 
                }
                return cont;
            }
        }
        public bool empty()
        {
            if (this.Primero == null)
            {
                Console.WriteLine("la cola esta vacia");
                return true;
            }
            else
            {
                Console.WriteLine("existen datos");
                return false;
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
