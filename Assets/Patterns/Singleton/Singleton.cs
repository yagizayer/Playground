using UnityEngine;

namespace Patterns.Singleton
{
    public abstract class Singleton<T> : MonoBehaviour where T : Object
    {
        protected static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null) _instance = FindObjectOfType<T>();
                return _instance;
            }
        }
        
        public virtual void Awake()
        {
            if (_instance == null)
                _instance = this as T;
            else
                Destroy(gameObject);
        }
    }
}