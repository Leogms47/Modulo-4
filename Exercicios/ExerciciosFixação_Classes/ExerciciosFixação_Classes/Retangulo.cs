using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosFixação_Classes
{
    class Retangulo
    {
        public double H, B;

        public double Area()
        {
            //A = b * h
            return B * H;
        }

        public double Perimetro()
        {
            //P = 2 * (b + h)
            return 2 * (B + H);
        }

        public double Diagonal()
        {
            //d2 = b2^2^ + h2^2^
            return Math.Sqrt(B) + (H);
        }
    }
}