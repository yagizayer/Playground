using UnityEngine;

namespace Patterns.Structural.Bridge.Scripts
{
    public class GreenEnemy : Enemy
    {
        [SerializeField]
        private GameObject vehiclePrefab;

        private void Start() => Activate(Color.green, vehiclePrefab);
    }
}