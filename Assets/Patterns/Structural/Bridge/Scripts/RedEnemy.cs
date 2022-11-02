using UnityEngine;

namespace Patterns.Structural.Bridge.Scripts
{
    public class RedEnemy : Enemy
    {
        [SerializeField]
        private GameObject vehiclePrefab;

        private void Start() => Activate(Color.red, vehiclePrefab);
    }
}