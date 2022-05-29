using System;
using System.Globalization;

namespace ExercicioFixação2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcinario f;
            f = new Funcinario();

            Console.WriteLine("Infome os dados do funcionario: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine("");

            Console.WriteLine("Digite a porcentagem para o aumento do salario: ");
            double por = double.Parse(Console.ReadLine());
            f.AumentarSalario(por);

            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + f);
            Console.WriteLine("");
        }
    }
}
