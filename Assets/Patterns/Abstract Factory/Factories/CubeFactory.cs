using Patterns.Abstract_Factory.Shapes;
using UnityEngine;

namespace Patterns.Abstract_Factory.Factories
{
    public class CubeFactory : IFactory
    {
        private readonly Color _color;
        private readonly float _size;

        public CubeFactory(Color color, float size)
        {
            _color = color;
            _size = size;
        }

        public Shape CreateShape() => new Cube(_color, _size);
    }
}