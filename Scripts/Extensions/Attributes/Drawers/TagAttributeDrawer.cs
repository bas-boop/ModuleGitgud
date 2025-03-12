using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR
namespace Framework.Extensions.Attributes.Drawers
{
    [CustomPropertyDrawer(typeof(TagAttribute))]
    public sealed class TagAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType == SerializedPropertyType.String)
            {
                EditorGUI.BeginProperty(position, label, property);
                property.stringValue = EditorGUI.TagField(position, label, property.stringValue);

                if (property.stringValue == string.Empty)
                    property.stringValue = "Untagged";
                
                EditorGUI.EndProperty();
            }
            else
                EditorGUI.PropertyField(position, property, label);
        }
    }
}
#endif