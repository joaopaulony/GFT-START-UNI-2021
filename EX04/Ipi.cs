using System;
using System.Collections.Generic;
using System.Text;

namespace EX04
{
    public class Cofins : Imposto
    {
        public double CalculoImp(double valor)
        {
            if (valor > 25000)
            {
                valor *= 0.05;
                return valor;
            }
            else (valor =< 25000)
            {
                valor *= 0.10;
                return valor;
            }
        }
    }
}