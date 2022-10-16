using System;
using UnityEngine;

namespace Patterns.Factory
{
    public class ShapeFactory
    {
        public static Shape GetShape(PrimitiveType type, Color color, float size)
        {
            switch (type)
            {
                case PrimitiveType.Sphere:
                    return  new Sphere(color, size);
                case PrimitiveType.Capsule:
                    return new Capsule(color, size);
                case PrimitiveType.Cube:
                    return new Cube(color, size);
                case PrimitiveType.Cylinder:
                case PrimitiveType.Plane:
                case PrimitiveType.Quad:
                default:
                    return null;
            }
        }
    }
}