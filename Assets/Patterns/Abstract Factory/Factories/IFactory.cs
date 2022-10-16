using Patterns.Abstract_Factory.Shapes;
using UnityEngine;

namespace Patterns.Abstract_Factory.Factories
{
    public interface IFactory
    {
        public Shape CreateShape();
    }
}