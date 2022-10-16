using UnityEngine;

namespace Patterns.Factory
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