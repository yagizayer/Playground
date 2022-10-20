using UnityEngine;

namespace Patterns.Structural.Decorator.BaseClasses
{
    public interface IBurger
    {
        public float Height { get; set; }
        public Transform Parent { get; set; }
        public void Assemble();
    }
}