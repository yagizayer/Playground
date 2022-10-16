using UnityEngine;

namespace Patterns.Factory
{
    public abstract class Shape
    {
        public PrimitiveType Type { get; protected set; }
        public Color Color { get; protected set; }
        public float Size { get; protected set; }
    }
}