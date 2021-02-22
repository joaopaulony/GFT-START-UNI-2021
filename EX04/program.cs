using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor:");
            double valor = Convert.ToDouble(Console.ReadLine());

            var ICMS = new Icms();
            var IPI = new Ipi();
            var COFINS = new Cofins();

            Console.WriteLine("ICMS: {0}",icms.CalculoImp(valor));
            Console.WriteLine("IPI: {0}"ipi.CalculoImp(valor));
            Console.WriteLine("CONFINS: {0}"cofins.CalculoImp(valor));

            double TotalImpostos = ICMS.CalculoImp(valor) + IPI.CalculoImp(valor) + COFINS.CalculoImp(valor);
            double valorTotal = valor + TotalImpostos;

            Console.WriteLine("Valor Final: {0}",valorTotal);
        }
    }
}