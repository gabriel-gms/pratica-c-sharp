using metodos_abstratos.Entities.Enums;

namespace metodos_abstratos.Entities
{
    internal class Rectangule : Shape
    {
        public Double Width;
        public Double Height;

        public Rectangule(double width, double height, Color color): base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
