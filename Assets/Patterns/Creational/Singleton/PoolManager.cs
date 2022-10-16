using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton
{
    public class PoolManager : Singleton<PoolManager>
    {
        [SerializeField]
        private List<ObjectPool> pools = new();

        private readonly Dictionary<string, ObjectPool> _poolDictionary = new();

        public override void Awake()
        {
            foreach (var pool in pools)
            {
                pool.Initialize();
                _poolDictionary.Add(pool.name, pool);
            }
        }

        public static GameObject Get(string poolName) => Instance._poolDictionary[poolName].Get();
        public static GameObject GetActive(string poolName) => Instance._poolDictionary[poolName].GetActive();
        
        public static void Return(string poolName, GameObject obj) => Instance._poolDictionary[poolName].Return(obj);
    }
}