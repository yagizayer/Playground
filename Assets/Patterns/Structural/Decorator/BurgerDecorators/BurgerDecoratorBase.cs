using Patterns.Structural.Decorator.BaseClasses;
using UnityEngine;

namespace Patterns.Structural.Decorator.BurgerDecorators
{
    public abstract class BurgerDecoratorBase : IBurger
    {
        protected IBurger Burger;

        public float Height { get; set; }
        public Transform Parent { get; set; }

        protected BurgerDecoratorBase(IBurger burger)
        {
            Burger = burger;
            Height = burger.Height + .3f;
            Parent = burger.Parent;
        }

        public virtual void Assemble() => Burger.Assemble();
    }
}