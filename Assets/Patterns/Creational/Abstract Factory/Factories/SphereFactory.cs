using Patterns.Abstract_Factory.Shapes;
using UnityEngine;

namespace Patterns.Abstract_Factory.Factories
{
    public class SphereFactory : IFactory
    {
        private readonly Color _color;
        private readonly float _size;

        public SphereFactory(Color color, float size)
        {
            _color = color;
            _size = size;
        }

        public Shape CreateShape() => new Sphere(_color, _size);
    }
}