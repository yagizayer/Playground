using UnityEngine;

namespace Patterns.Prototype
{
    public class PrototypeManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject prefab;

        private WavePool _wavePool;

        public void GeneratePool()
        {
            _wavePool = new WavePool(prefab);
            _wavePool.Generate();
        }

        public void FloatParticles()
        {
            var wave = _wavePool.Clone();
            for (var rowNo = 0; rowNo < wave.RowCount; rowNo++)
            {
                for (var columnNo = 0; columnNo < wave.ColumnCount; columnNo++)
                {
                    var particle = wave.Particles[rowNo, columnNo];
                    particle.transform.position = new Vector3(rowNo, Mathf.Sin(Time.time + rowNo + columnNo), columnNo);
                }
            }
        }
        
        public void RainbowParticles()
        {
            var wave = _wavePool.Clone();
            for (var rowNo = 0; rowNo < wave.RowCount; rowNo++)
            {
                for (var columnNo = 0; columnNo < wave.ColumnCount; columnNo++)
                {
                    var particle = wave.Particles[rowNo, columnNo];
                    wave.GetRenderer(particle).sharedMaterial.color = Random.ColorHSV();
                }
            }
        }
    }
}