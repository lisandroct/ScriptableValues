using UnityEngine;
using UnityEngine.Serialization;

namespace lisandroct.ScriptableValues
{
    public abstract class ScriptableValue<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        [FormerlySerializedAs("m_Value")] [SerializeField]
        private T _value;

        private T _runtimeValue { get; set; }

        public T Value {
            get { return _runtimeValue; }
            set { _runtimeValue = value; }
        }

        public void OnAfterDeserialize() {
            _runtimeValue = _value;
        }

        public void OnBeforeSerialize() { }
    }
}