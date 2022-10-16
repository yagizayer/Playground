using UnityEngine;

namespace Patterns.Factory
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