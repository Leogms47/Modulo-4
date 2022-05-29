using System;
using System.Globalization;

namespace ExerciciosFixação3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            BoletimAluno aluno;
            aluno = new BoletimAluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Informe as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL: " + aluno.NotaFiinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) +" PONTOS");
            }
        }
    }
}
