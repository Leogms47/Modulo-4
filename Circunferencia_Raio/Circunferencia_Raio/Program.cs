using System;
using System.Globalization;

namespace Circunferencia_Raio
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            //As variaveis recebem os calculos feitos pela chamada direta da classe independente de objetos.
            double circ = Calculadora.Circunferencia(raio);
            double volu = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volu.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}
