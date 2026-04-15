using metodos_abstratos.Entities.Enums;

namespace metodos_abstratos.Entities
{
    internal class Circle : Shape
    {
        public Double Radius;

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
