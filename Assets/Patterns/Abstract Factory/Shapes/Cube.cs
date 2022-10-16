using UnityEngine;

namespace Patterns.Abstract_Factory.Shapes
{
    public class Cube : Shape
    {
        public Cube( Color color, float size)
        {
            Type = PrimitiveType.Cube;
            Color = color;
            Size = size;
        }
    }
}