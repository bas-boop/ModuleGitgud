using System.Collections.Generic;
using Framework.Gameplay.BulletSystem;
using UnityEditor;
using UnityEngine;

namespace MyEditor.CustomClassEditors
{
    [CustomPropertyDrawer(typeof(SplineSegment))]
    public sealed class SplineSegmentDrawer : PropertyDrawer
    {
        private const string CUSTOM_SPLINE_CONTAINER_PROP_NAME = "customSplineContainer";
        private const string ROUTE_PROP_NAME = "route";
        private const string USE_CUSTOM_SPLINE_LABEL = "useCustomSpline";

        private readonly Dictionary<string, SerializedProperty> _propertyCache = new ();

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float baseHeight = EditorGUIUtility.singleLineHeight;
            float totalHeight = baseHeight + EditorGUIUtility.standardVerticalSpacing;

            if (IsCustomSplineProperty(property))
                totalHeight += (baseHeight + EditorGUIUtility.standardVerticalSpacing) * 2;

            return totalHeight;
        }

        public override void OnGUI(
            Rect position,
            SerializedProperty property,
            GUIContent label)
        {
            CacheSerializedProperties(property);

            EditorGUI.LabelField(GetLabelRect(position), property.displayName);

            if (!IsCustomSplineProperty(property))
                return;

            DrawCustomSplineToggle(position);
            DrawCustomSplineProperty(position);
        }

        private void CacheSerializedProperties(SerializedProperty property)
        {
            _propertyCache.Clear();

            _propertyCache.Add(CUSTOM_SPLINE_CONTAINER_PROP_NAME, property.FindPropertyRelative(CUSTOM_SPLINE_CONTAINER_PROP_NAME));
            _propertyCache.Add(ROUTE_PROP_NAME, property.FindPropertyRelative(ROUTE_PROP_NAME));
            _propertyCache.Add(USE_CUSTOM_SPLINE_LABEL, property.FindPropertyRelative(USE_CUSTOM_SPLINE_LABEL));
        }

        private bool IsCustomSplineProperty(SerializedProperty property)
        {
            CacheSerializedProperties(property);
            return GetCachedProperty(USE_CUSTOM_SPLINE_LABEL).propertyType == SerializedPropertyType.Boolean;
        }

        private Rect GetLabelRect(Rect position)
            => new (position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
        
        private SerializedProperty GetCachedProperty(string propertyName) => _propertyCache[propertyName];

        private void DrawCustomSplineToggle(Rect position)
        {
            Rect toggleLabelRect = new (
                position.x,
                position.y + EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing,
                EditorGUIUtility.labelWidth,
                EditorGUIUtility.singleLineHeight
            );

            Rect toggleRect = new (
                position.x + EditorGUIUtility.labelWidth,
                position.y + EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing,
                position.width - EditorGUIUtility.labelWidth,
                EditorGUIUtility.singleLineHeight
            );

            EditorGUI.LabelField(toggleLabelRect, USE_CUSTOM_SPLINE_LABEL);
            GetCachedProperty(USE_CUSTOM_SPLINE_LABEL).boolValue = EditorGUI.Toggle(toggleRect, GetCachedProperty(USE_CUSTOM_SPLINE_LABEL).boolValue);
        }

        private void DrawCustomSplineProperty(Rect position)
        {
            Rect contentRect = new (
                position.x,
                position.y + EditorGUIUtility.singleLineHeight * 2 + EditorGUIUtility.standardVerticalSpacing * 2,
                position.width,
                EditorGUIUtility.singleLineHeight
            );

            EditorGUI.PropertyField(contentRect, GetCachedProperty(USE_CUSTOM_SPLINE_LABEL).boolValue 
                ? GetCachedProperty(CUSTOM_SPLINE_CONTAINER_PROP_NAME) 
                : GetCachedProperty(ROUTE_PROP_NAME), GUIContent.none);
        }
    }
}