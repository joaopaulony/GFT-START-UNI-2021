using System;
using System.Collections.Generic;
using System.Text;

namespace EX04
{
    public class Cofins : Imposto
    {
        public double CalculoImp(double valor)
        {
            if (valor > 12000)
            {
                valor *= 0.08;
                return valor;
            }
            else
            {
                return 0;
            }
        }
    }
}