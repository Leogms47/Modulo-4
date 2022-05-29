using System;

namespace Triangulo
{
    class Triangulo_POO
    {
        //Atributos

        public double A;
        public double B;
        public double C;

        //Metôdo criado para calcular a área de um triâgulo
        public double Area()
        {
            //Formula de Herom
            double p = (A + B + C) / 2.0f;

            //Retorna o calculo da raiz quadrada da equação abaixo
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
