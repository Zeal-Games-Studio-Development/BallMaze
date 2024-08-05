using UnityEngine;

namespace ZealMVC.Runtime.Patterns
{
    public abstract class ASingleton <T> : MonoBehaviour 
        where T : ASingleton <T>
    {
        public static T Instance;
        protected virtual void Awake()
        {
            Instance ??= GetComponent<T>();
        }
    }
}