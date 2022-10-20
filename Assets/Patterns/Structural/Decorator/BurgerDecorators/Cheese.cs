using Patterns.Structural.Decorator.BaseClasses;
using UnityEngine;

namespace Patterns.Structural.Decorator.BurgerDecorators
{
    public class Cheese : BurgerDecoratorBase
    {
        public static GameObject Prefab;

        public Cheese(IBurger burger) : base(burger)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Object.Instantiate(Prefab, Vector3.up * Height, Quaternion.identity, Burger.Parent);
        }
    }
}