using System;
using System.Globalization;

namespace ExerciciosFixação_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            

            Console.WriteLine("Informe a altura e a largura de um retângulo: ");
            Console.Write("Altura: ");
            r.H = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            r.B = double.Parse(Console.ReadLine());

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();
            
            Console.WriteLine("");
            Console.WriteLine("ÁREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
