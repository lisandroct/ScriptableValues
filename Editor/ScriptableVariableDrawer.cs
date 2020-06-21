using UnityEditor;
using UnityEngine;

namespace lisandroct.ScriptableValues
{
    public abstract class ScriptableVariableDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // Using BeginProperty / EndProperty on the parent property means that
            // prefab override logic works on the entire property.
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            //FloatVar var = fieldInfo.GetValue(property.serializedObject.targetObject) as FloatVar;
            SerializedProperty serialized = property.FindPropertyRelative("m_Serialized");

            if(serialized.objectReferenceValue == null) {
                SerializedProperty direct = property.FindPropertyRelative("m_Direct");

                // Calculate rects
                float serializedWidth = 160;
                var directRect = new Rect(position.x, position.y, position.width - serializedWidth - 5, position.height);
                var serializedRect = new Rect(position.x + directRect.width + 5, position.y, serializedWidth, position.height);

                // Draw fields - passs GUIContent.none to each so they are drawn without labels
                EditorGUI.PropertyField(serializedRect, serialized, GUIContent.none);
                EditorGUI.PropertyField(directRect, direct, GUIContent.none);
            } else {
                // Draw fields - passs GUIContent.none to each so they are drawn without labels
                EditorGUI.PropertyField(position, serialized, GUIContent.none);
            }

            EditorGUI.EndProperty();
        }
    }
}