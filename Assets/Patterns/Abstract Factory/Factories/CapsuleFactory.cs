using Patterns.Abstract_Factory.Shapes;
using UnityEngine;

namespace Patterns.Abstract_Factory.Factories
{
    public class CapsuleFactory : IFactory
    {
        private readonly Color _color;
        private readonly float _size;

        public CapsuleFactory(Color color, float size)
        {
            _color = color;
            _size = size;
        }

        public Shape CreateShape() => new Capsule(_color, _size);
    }
}