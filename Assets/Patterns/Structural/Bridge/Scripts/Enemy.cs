using UnityEngine;

namespace Patterns.Structural.Bridge.Scripts
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField]
        private Renderer myRenderer;

        private IVehicle _myVehicle;

        public void Activate(Color color, GameObject vehiclePrefab)
        {
            myRenderer.material.color = color;
            _myVehicle = Instantiate(vehiclePrefab).GetComponent<IVehicle>();
            _myVehicle.Agent.transform.position = transform.position;
            transform.SetParent(_myVehicle.Agent.transform);
            transform.localPosition = Vector3.up * 3;
            _myVehicle.Activate(color);
        }
    }
}