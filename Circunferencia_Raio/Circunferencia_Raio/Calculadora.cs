namespace Circunferencia_Raio
{
    class Calculadora
    {
        //atributo estático me contém o valor de PI
        public static double Pi = 3.14;

        //O método estático me retorna a circunferencia do valor do raio que recebe a entrada
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        //O método estático retornar o valor do volume de acordo com o valor de entrada armazenado na variavel raio
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
