namespace ExerciciosFixação3_Classes
{
    class BoletimAluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFiinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFiinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.00;
            }
            else
            {
                return 60.0 - NotaFiinal();
            }
        }
    }
}
