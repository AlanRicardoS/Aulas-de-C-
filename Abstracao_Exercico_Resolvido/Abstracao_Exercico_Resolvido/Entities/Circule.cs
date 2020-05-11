using Abstracao_Exercico_Resolvido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao_Exercico_Resolvido.Entities
{
    class Circule : Shape
    {
        public double Raius { get; set; }

        public Circule(double raius, Color color):base(color)
        {
            Raius = raius;
        }

        public override double Area()
        {
            return Math.PI * Raius * Raius;
        }
    }
}
