using System;
using System.Collections.Generic;
using System.Text;

namespace EX04
{
    public class Icms : IImposto
    {
        public double CalculoImp(double valor)
        {
            valor *= 0.30;
            return valor;
        }
    }
}
