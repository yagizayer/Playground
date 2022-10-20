using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton
{
    public class PoolManager : MonoBehaviour
    {
        #region Inspector

        [SerializeField]
        private List<ObjectPool> pools = new();

        private readonly Dictionary<string, ObjectPool> _poolDictionary = new();

        #endregion

        #region Singleton

        protected static PoolManager _instance;

        public static PoolManager Instance
        {
            get
            {
                if (_instance == null) _instance = FindObjectOfType<PoolManager>();
                return _instance;
            }
        }

        #endregion

        public void Awake()
        {
            if (_instance == null)
                _instance = this;
            else
                Destroy(gameObject);

            InitializePools();
        }

        public static GameObject Get(string poolName) => Instance._poolDictionary[poolName].Get();
        public static GameObject GetActive(string poolName) => Instance._poolDictionary[poolName].GetActive();

        public static void Return(string poolName, GameObject obj) => Instance._poolDictionary[poolName].Return(obj);

        private void InitializePools()
        {
            foreach (var pool in pools)
            {
                pool.Initialize();
                _poolDictionary.Add(pool.name, pool);
            }
        }
    }
}