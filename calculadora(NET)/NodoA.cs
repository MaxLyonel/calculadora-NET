using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_NET_
{
    class NodoA
    {
        public String dato;
        public NodoA hjoIzq;
        public NodoA hjoDer;
        public NodoA(String d)
        {
            dato = d;
            hjoIzq = null;
            hjoDer = null;
        }
    }
}
