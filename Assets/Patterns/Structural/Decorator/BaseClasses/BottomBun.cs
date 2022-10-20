using UnityEngine;

namespace Patterns.Structural.Decorator.BaseClasses
{
    public class BottomBun : IBurger
    {
        public GameObject Bun;

        public float Height { get; set; } = .3f;
        public Transform Parent { get; set; }

        public BottomBun(GameObject bun, Transform parent)
        {
            Bun = bun;
            Parent = parent;
        }

        public void Assemble()
        {
            Object.Instantiate(Bun, new Vector3(0, Height, 0), Quaternion.identity, Parent);
        }
    }
}