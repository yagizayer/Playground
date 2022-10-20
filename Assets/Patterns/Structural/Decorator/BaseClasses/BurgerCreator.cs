using System;
using System.Collections.Generic;
using System.Linq;
using Patterns.Structural.Decorator.BurgerDecorators;
using UnityEngine;

namespace Patterns.Structural.Decorator.BaseClasses
{
    public class BurgerCreator : MonoBehaviour
    {
        [SerializeField]
        private GameObject bunPrefab;

        [SerializeField]
        private GameObject pattyPrefab;

        [SerializeField]
        private GameObject cheesePrefab;

        [SerializeField]
        private GameObject tomatoPrefab;

        [SerializeField]
        private GameObject lettucePrefab;

        [SerializeField]
        private Transform burgerParent;

        private void Start()
        {
            Patty.Prefab ??= pattyPrefab;
            Cheese.Prefab ??= cheesePrefab;
            Tomato.Prefab ??= tomatoPrefab;
            Lettuce.Prefab ??= lettucePrefab;
            TopBun.Prefab ??= bunPrefab;
        }

        public void DoubleCheeseBurger()
        {
            Clear();
            var bottomBun = new BottomBun(bunPrefab, burgerParent);
            var patty = new Patty(bottomBun);
            var cheese = new Cheese(patty);
            var patty2 = new Patty(cheese);
            var cheese2 = new Cheese(patty2);
            var tomato = new Tomato(cheese2);
            var lettuce = new Lettuce(tomato);
            var topBun = new TopBun(lettuce);
            topBun.Assemble();
        }

        public void CheeseBurger()
        {
            Clear();
            var bottomBun = new BottomBun(bunPrefab, burgerParent);
            var patty = new Patty(bottomBun);
            var cheese = new Cheese(patty);
            var tomato = new Tomato(cheese);
            var lettuce = new Lettuce(tomato);
            var topBun = new TopBun(lettuce);
            topBun.Assemble();
        }

        public void PlainBurger()
        {
            Clear();
            var bottomBun = new BottomBun(bunPrefab, burgerParent);
            var patty = new Patty(bottomBun);
            var tomato = new Tomato(patty);
            var lettuce = new Lettuce(tomato);
            var topBun = new TopBun(lettuce);
            topBun.Assemble();
        }

        public void VeggieBurger()
        {
            Clear();
            var bottomBun = new BottomBun(bunPrefab, burgerParent);
            var tomato = new Tomato(bottomBun);
            var lettuce = new Lettuce(tomato);
            var topBun = new TopBun(lettuce);
            topBun.Assemble();
        }

        public void Clear()
        {
            var children = burgerParent.Cast<Transform>().ToList();
            children.ForEach(child => Destroy(child.gameObject));
        }
    }
}