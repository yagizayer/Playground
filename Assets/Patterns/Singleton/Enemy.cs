using UnityEngine;

namespace Patterns.Singleton
{
    public class Enemy : MonoBehaviour
    {
        private void Update()
        {
            transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time), transform.position.z);
        }
    }
}
