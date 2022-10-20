using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton
{
    public class EnemySpawner : MonoBehaviour
    {
        public void SpawnEnemies(int amount)
        {
            var enemyList = new List<GameObject>();
            for (var enemyNo = 0; enemyNo < amount; enemyNo++)
            {
                var newEnemy = PoolManager.Get("Enemies");
                enemyList.Add(newEnemy);
            }
            
            foreach (var enemy in enemyList)
                enemy.transform.position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
        }

        public void KillEnemies(int amount)
        {
            for (var enemyNo = 0; enemyNo < amount; enemyNo++)
            {
                var enemyToReturn = PoolManager.GetActive("Enemies");
                PoolManager.Return("Enemies", enemyToReturn);
            }
        }
    }
}