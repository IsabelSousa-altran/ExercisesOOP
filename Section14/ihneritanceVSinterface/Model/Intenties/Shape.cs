using ihneritanceVSinterface.Model.Enums;

namespace ihneritanceVSinterface.Model.Intenties
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
