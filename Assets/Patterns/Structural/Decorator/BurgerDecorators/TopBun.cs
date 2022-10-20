using Patterns.Structural.Decorator.BaseClasses;
using UnityEngine;

namespace Patterns.Structural.Decorator.BurgerDecorators
{
    public class TopBun : BurgerDecoratorBase
    {
        public static GameObject Prefab;

        public TopBun(IBurger burger) : base(burger)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Object.Instantiate(Prefab, Vector3.up * Height, Quaternion.identity, Burger.Parent);
        }
    }
}