using Patterns.Abstract_Factory.Factories;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.Abstract_Factory
{
    public class ShapeSpawner : MonoBehaviour
    {
        public void SpawnSphere()
        {
            var shape = ShapeFactory.CreateShape(new SphereFactory(Random.ColorHSV(), Random.Range(.3f, 1)));

            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }

        public void SpawnCube()
        {
            var shape = ShapeFactory.CreateShape(new CubeFactory(Random.ColorHSV(), Random.Range(.3f, 1)));

            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }

        public void SpawnCapsule()
        {
            var shape = ShapeFactory.CreateShape(new CapsuleFactory(Random.ColorHSV(), Random.Range(.3f, 1)));

            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }
    }
}