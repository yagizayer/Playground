using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Patterns.Singleton
{
    [Serializable]
    public class ObjectPool
    {
        public string name;
        public GameObject prefab;
        public Transform parent;
        public int poolSize;
        public List<GameObject> pool;
        public List<GameObject> activePool;

        public void Initialize()
        {
            for (var i = 0; i < poolSize; i++) CreateObject();
        }
        
        public GameObject Get()
        {
            foreach (var obj in pool.Where(obj => !obj.activeInHierarchy))
            {
                obj.SetActive(true);
                activePool.Add(obj);
                return obj;
            }

            var newObj = CreateObject();
            newObj.SetActive(true);
            activePool.Add(newObj);
            return newObj;
        }
        
        public GameObject GetActive() => activePool.FirstOrDefault(obj => obj.activeInHierarchy);

        public void Return(GameObject obj)
        {
            obj.SetActive(false);
            activePool.Remove(obj);
        }

        public GameObject CreateObject()
        {
            var obj = Object.Instantiate(prefab, parent, true);
            obj.SetActive(false);
            pool.Add(obj);
            return obj;
        }
    }
}