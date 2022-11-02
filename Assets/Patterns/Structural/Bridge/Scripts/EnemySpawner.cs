using UnityEngine;

namespace Patterns.Structural.Bridge.Scripts
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject redEnemyPrefab;

        [SerializeField]
        private GameObject yellowEnemyPrefab;

        [SerializeField]
        private GameObject greenEnemyPrefab;

        public void SpawnRedEnemy()
        {
            var xPos = Random.Range(-10, 10);
            var zPos = Random.Range(-10, 10);
            Instantiate(redEnemyPrefab, new Vector3(xPos, 0, zPos), Quaternion.identity);
        }
        
        public void SpawnYellowEnemy()
        {
            var xPos = Random.Range(-10, 10);
            var zPos = Random.Range(-10, 10);
            Instantiate(yellowEnemyPrefab, new Vector3(xPos, 0, zPos), Quaternion.identity);
        }
        
        public void SpawnGreenEnemy()
        {
            var xPos = Random.Range(-10, 10);
            var zPos = Random.Range(-10, 10);
            Instantiate(greenEnemyPrefab, new Vector3(xPos, 0, zPos), Quaternion.identity);
        }
    }
}