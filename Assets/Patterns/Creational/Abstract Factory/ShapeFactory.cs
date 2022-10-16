using Patterns.Abstract_Factory.Factories;
using Patterns.Abstract_Factory.Shapes;

namespace Patterns.Abstract_Factory
{
    public class ShapeFactory
    {
        public static Shape CreateShape(IFactory shapeFactory) => shapeFactory.CreateShape();
    }
}
