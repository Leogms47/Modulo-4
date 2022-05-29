using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Criamos duas variaveis do tipo Triangulo_POO que é a classe que criamos para instanciar os valores 
             de x e y para os atributos da classe que são A B e C variáveis publicas do tipo double.*/
            Triangulo_POO x, y;

            /*Instaciamos as variáveis x e y criando um novo Triangulo_POO() que fará a locação dos valores digitados
            nos atributos da classe*/
            x = new Triangulo_POO();
            y = new Triangulo_POO();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            /*As variaveis abaixo recebem a operação do método Area() que é acionada para o calcular os valores do 
            triangulo x ou y e os valores sãoi armazenados nas respectivas variaveis areaX e areaY. */
            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X: " + areaX.ToString());
            Console.WriteLine("Area de Y: " + areaY.ToString("F0"));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
