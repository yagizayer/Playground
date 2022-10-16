using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.Factory
{
    public class ShapeSpawner : MonoBehaviour
    {
        public void SpawnSphere()
        {
            var shape = ShapeFactory.GetShape(PrimitiveType.Sphere, Random.ColorHSV(), Random.Range(.5f, 1));
            
            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }
        
        public void SpawnCube()
        {
            var shape = ShapeFactory.GetShape(PrimitiveType.Cube, Random.ColorHSV(), Random.Range(.5f, 1));
            
            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }
        
        public void SpawnCapsule()
        {
            var shape = ShapeFactory.GetShape(PrimitiveType.Capsule, Random.ColorHSV(), Random.Range(.5f, 1));
            
            var go = GameObject.CreatePrimitive(shape.Type);
            go.GetComponent<Renderer>().material.color = shape.Color;
            go.transform.localScale = Vector3.one * shape.Size;
            go.transform.position = Random.insideUnitSphere * 5;
        }
    }
}