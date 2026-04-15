using metodos_abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace metodos_abstratos.Entities
{
    abstract internal class Shape
    {
        public Color Color;

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract Double Area();
    }
}
