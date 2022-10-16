using UnityEngine;

namespace Patterns.Factory.Shapes
{
    public class Capsule : Shape
    {
        public Capsule(Color color, float size)
        {
            Type = PrimitiveType.Capsule;
            Color = color;
            Size = size;
        }
    }
}