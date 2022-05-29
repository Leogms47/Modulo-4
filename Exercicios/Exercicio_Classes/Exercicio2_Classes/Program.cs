using System;

namespace Exercicio2_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario n1, n2, s1, s2;

            n1 = new Funcionario();
            n2 = new Funcionario();
            s1 = new Funcionario();
            s2 = new Funcionario();

            Console.WriteLine("Digite os dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            n1.Nome = Console.ReadLine().ToString();
            Console.Write("Salário: ");
            s1.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados do segundo funcionário: ");
            Console.Write("Nome: ");
            n2.Nome = Console.ReadLine().ToString();
            Console.Write("Salário: ");
            s2.Salario = float.Parse(Console.ReadLine());

            float mediaSalario = (s1.Salario + s2.Salario) / 2;

            Console.WriteLine("Média salárial dos funcionários é de: " + mediaSalario);
            
        }
    }
}
