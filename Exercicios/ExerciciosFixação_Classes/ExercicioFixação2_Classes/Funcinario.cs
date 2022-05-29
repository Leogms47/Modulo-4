using System.Globalization;

namespace ExercicioFixação2_Classes
{
    class Funcinario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome + ", Salario Liquido: " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    } 

}
