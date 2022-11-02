using UnityEngine;
using UnityEngine.AI;

namespace Patterns.Structural.Bridge.Scripts
{
    public interface IVehicle
    {
        public NavMeshAgent Agent { get; }
        public Renderer Renderer { get; }
        public void Activate(Color color);
    }
}