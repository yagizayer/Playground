using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Patterns.Structural.Bridge.Scripts
{
    public class CapsuleVehicle : MonoBehaviour, IVehicle
    {
        [field: SerializeField] public NavMeshAgent Agent { get; private set; }
        [field: SerializeField] public Renderer Renderer { get; private set; }

        public void Activate(Color color)
        {
            Renderer.material.color = color;
            Agent.isStopped = false;
            Agent.SetDestination(transform.position);
            StartCoroutine(StartMoving_Co());
        }

        private IEnumerator StartMoving_Co()
        {
            while (true)
            {
                while ((Agent.transform.position - Agent.destination).magnitude > 1f) yield return null;
                var xPos = Random.Range(-10, 10);
                var zPos = Random.Range(-10, 10);
                Agent.SetDestination(new Vector3(xPos, 0, zPos));
                Debug.Log("New Target (Capsule) : " + Agent.destination);
            }
        }
    }
}