using Patterns.Structural.Decorator.BaseClasses;
using UnityEngine;

namespace Patterns.Structural.Decorator.BurgerDecorators
{
    public class Lettuce : BurgerDecoratorBase
    {
        public static GameObject Prefab;

        public Lettuce(IBurger burger) : base(burger)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Object.Instantiate(Prefab, Vector3.up * Height, Quaternion.identity, Burger.Parent);
        }
    }
}