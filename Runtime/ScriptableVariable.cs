using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace lisandroct.ScriptableValues
{
    [Serializable]
    public abstract class ScriptableVariable<A, B> where B : ScriptableValue<A>
    {
        [FormerlySerializedAs("m_Serialized")] [SerializeField]
        private B _serialized;
        private B serialized { get { return _serialized; } }
        [FormerlySerializedAs("m_Direct")] [SerializeField]
        private A _direct;
        private A direct { get { return _direct; } }

        public A Value { get { return serialized != null ? serialized.Value : direct; } }
    }
}