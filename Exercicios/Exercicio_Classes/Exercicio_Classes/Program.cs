using System;

namespace Exercicio_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa n1, i1, n2, i2;

            n1 = new Pessoa();
            i1 = new Pessoa();
            n2 = new Pessoa();
            i2 = new Pessoa();
            
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            n1.Nome = Console.ReadLine().ToString();
            Console.Write("Idade: ");
            i1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunada pessoa:");
            Console.Write("Nome: ");
            n2.Nome = Console.ReadLine().ToString();
            Console.Write("Idade: ");
            i2.Idade = int.Parse(Console.ReadLine());

            if(i1.Idade > i2.Idade)
            {
                Console.WriteLine("A maior idade é da(o): " + n1.Nome + " que tem " + i1.Idade + " anos.");
            }
            else
            {
                Console.WriteLine("A maior idade é da(o): " + n2.Nome + " que tem " + i2.Idade + " anos.");
            }
        }
    }
}
