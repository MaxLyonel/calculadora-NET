using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_NET_
{
    class ArbolBinario
    {
        public NodoA raiz;
        public ArbolBinario()
        {
            raiz = null;
        }
        public Boolean esHoja(NodoA x)
        {
            return x.hjoDer == null && x.hjoIzq == null;
        }
        public void insertar_x_abajo(String d)
        {
            NodoA nuevo = new NodoA(d);
            NodoA anterior;
            if(raiz != null)
            {
                if (esHoja(raiz))
                {
                    anterior = raiz;
                    raiz = nuevo;
                    raiz.hjoIzq = anterior;
                } else if(raiz.hjoIzq != null && raiz.hjoDer == null){
                    raiz.hjoDer = nuevo;
                } else if(raiz.hjoDer != null && raiz.hjoIzq == null)
                {
                    raiz.hjoIzq = nuevo;
                } else { 
                    if(d.Equals("+") || d.Equals("-"))
                    {
                        anterior = raiz;
                        raiz = nuevo;
                        raiz.hjoIzq = anterior;
                    } else if(d.Equals("x") || d.Equals("/"))
                    {
                        if(raiz.dato.Equals("-") || raiz.dato.Equals("+"))
                        {
                            NodoA temp = raiz.hjoDer;
                            raiz.hjoDer = nuevo;
                            nuevo.hjoIzq = temp;
                        } else if(raiz.dato.Equals("x") || raiz.dato.Equals("/")) {
                            anterior = raiz;
                            raiz = nuevo;
                            raiz.hjoIzq = anterior;
                        }
                    } else
                    {
                        anterior = raiz.hjoDer;
                        anterior.hjoDer = nuevo;
                    }
                }
            } else
            {
                raiz = nuevo;
            }
        }

        public double evaluar(NodoA raiz)
        {
            NodoA d = raiz;
            String dato = d.dato;
            NodoA I = d.hjoIzq;
            NodoA D = d.hjoDer;

            if (dato.Equals("+"))
                return evaluar(I) + evaluar(D);
            if (dato.Equals("-"))
                return evaluar(I) - evaluar(D);
            if (dato.Equals("x"))
                return evaluar(I) * evaluar(D);
            if (dato.Equals("/"))
                return evaluar(I) / evaluar(D);

            /*return Int32.Parse(dato);*/
            return double.Parse(dato);
        }
    }
}
