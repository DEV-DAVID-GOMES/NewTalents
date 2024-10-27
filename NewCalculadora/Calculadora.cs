using System;
using System.Collections.Generic;

namespace NewCalculadora
{
    public class Calculadora
    {
        private List<string> listahistorico;

        public Calculadora()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            listahistorico.Insert(0, "res: " + res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listahistorico.Insert(0, "res: " + res);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listahistorico.Insert(0, "res: " + res);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            if (val2 == 0)
                throw new DivideByZeroException("Divisor não pode ser zero.");

            int res = val1 / val2;
            listahistorico.Insert(0, "res: " + res);
            return res;
        }

        public List<string> Historico()
        {
            if (listahistorico.Count > 3)
                listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
