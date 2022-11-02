using UnityEngine;

namespace Patterns.Structural.Bridge.Scripts
{
    public class YellowEnemy : Enemy
    {
        [SerializeField]
        private GameObject vehiclePrefab;

        private void Start() => Activate(Color.yellow, vehiclePrefab);
    }
}