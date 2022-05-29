using System;
using System.Globalization;

namespace Exercicio_MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            double result = ConversorDeMoeda.DolarParaReal(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
