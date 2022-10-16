using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class WavePool : ICloneable<WavePool>
    {
        private const int Rows = 100;
        private const int Columns = 100;

        public int RowCount => Rows;
        public int ColumnCount => Columns;
        public GameObject Prefab { get; }

        public GameObject[,] Particles { get; private set; }
        private Dictionary<GameObject, Renderer> _renderers;

        public WavePool(GameObject prefab) => Prefab = prefab;

        private WavePool(GameObject[,] particles, Dictionary<GameObject, Renderer> renderers) =>
            (Particles, _renderers) = (particles, renderers);

        public Renderer GetRenderer(GameObject particle) => _renderers[particle];

        public void Generate()
        {
            Particles = new GameObject[Rows, Columns];
            _renderers = new Dictionary<GameObject, Renderer>();
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Columns; j++)
                {
                    var particle = Object.Instantiate(Prefab);
                    particle.transform.position = new Vector3(i, 0, j);
                    Particles[i, j] = particle;
                    _renderers.Add(particle, particle.GetComponent<Renderer>());
                }
            }
        }

        public WavePool Clone() => new(Particles, _renderers);
    }
}