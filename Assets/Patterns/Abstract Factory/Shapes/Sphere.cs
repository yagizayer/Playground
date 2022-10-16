using UnityEngine;

namespace Patterns.Abstract_Factory.Shapes
{
    public class Sphere : Shape
    {
        public Sphere( Color color, float size)
        {
            Type = PrimitiveType.Sphere;
            Color = color;
            Size = size;
        }
    }
}