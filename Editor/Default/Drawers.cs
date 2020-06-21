using UnityEditor;

namespace lisandroct.ScriptableValues.Default
{
    [CustomPropertyDrawer(typeof(BoolVar))]
    public class BoolVarDrawer : ScriptableVariableDrawer { }

    [CustomPropertyDrawer(typeof(IntVar))]
    public class IntVarDrawer : ScriptableVariableDrawer { }

    [CustomPropertyDrawer(typeof(FloatVar))]
    public class FloatVarDrawer : ScriptableVariableDrawer { }

    [CustomPropertyDrawer(typeof(Vector2Var))]
    public class Vector2VarDrawer : ScriptableVariableDrawer { }

    [CustomPropertyDrawer(typeof(Vector3Var))]
    public class Vector3VarDrawer : ScriptableVariableDrawer { }
}