using Abstracao_Exercico_Resolvido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao_Exercico_Resolvido.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

            

    }
}
