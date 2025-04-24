using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class nodo
    {
        public string dato;

        public nodo sig;

        public nodo(string dato)
        {
            Dato = dato;
        }
        public string Dato { get => dato; set => dato = value; }
        internal nodo Sig { get => sig; set => sig = value; }
    }
}
