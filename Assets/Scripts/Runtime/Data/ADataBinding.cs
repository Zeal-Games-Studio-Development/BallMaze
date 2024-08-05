using System;
using UnityEngine;

namespace ZealMVC.Runtime.Manager
{
    [Serializable]
    public abstract class ADataBinding <T> 
    {
        [SerializeField] private T _value;
        protected Action<T> _onChanged;
        public virtual T Value
        {
            get => _value;
            set
            {
                if (_value.Equals(value)) return; 
                _value = value;
                _onChanged?.Invoke(value);
            }
        }

        public void AddListener(Action<T> listener) 
        {
            _onChanged -= listener;
            _onChanged += listener;
        }

        public void RemoveListener (Action<T> listener) 
        {
            _onChanged -= listener;
        }

        public void RemoveAllListener() => _onChanged = default;
    }

    [Serializable]
    public class IntValue : ADataBinding <int> { }
    [Serializable]
    public class FloatValue : ADataBinding <float> { }
    [Serializable]
    public class BoolValue : ADataBinding <bool> { }
    [Serializable]
    public class StringValue : ADataBinding <string> { }
    [Serializable]
    public class LevelValue : ADataBinding<LevelData> { }

}
