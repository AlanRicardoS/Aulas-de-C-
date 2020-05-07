using System;


namespace Membros_Estaticos_2
{
    class Calculadora
    {
        public static double Pi = Math.PI; // Número de Pi

        public static double circunferencia(double raio) // Calcula Circunferência
        {
            return 2 * Pi * raio;
        }
        public static double Volume(double r) // Calcula volume
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
