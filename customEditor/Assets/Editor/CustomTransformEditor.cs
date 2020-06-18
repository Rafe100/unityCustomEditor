using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CustomTransform))]
public class CustomTransformEditor : Editor
{
    public override void OnInspectorGUI()
    {
        CustomTransform customTarget = (CustomTransform)target;
        {
            EditorGUILayout.BeginHorizontal();
            GUI.color = Color.yellow;
            if (GUILayout.Button("click " + customTarget.GetInstanceID(), GUILayout.Width(200)))
            {
                Debug.Log("gui lay out button click");
            }
            EditorGUILayout.Separator();
            EditorGUILayout.LabelField("Target: " + customTarget.gameObject.name);
            EditorGUILayout.EndHorizontal();
        }
        EditorGUILayout.Separator();
        {
            GUI.color = Color.cyan;
            EditorGUILayout.BeginVertical();
            {
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                EditorGUILayout.LabelField("InstanceID(int)", GUILayout.Width(100)); EditorGUILayout.Separator();
                EditorGUILayout.TextField(customTarget.GetInstanceID().ToString());
                EditorGUILayout.EndHorizontal();
            }
            {
                EditorGUILayout.BeginHorizontal(EditorStyles.toolbar);
                EditorGUILayout.LabelField("InstanceID(uint)", GUILayout.Width(100)); EditorGUILayout.Separator();
                EditorGUILayout.TextField(((uint)customTarget.GetInstanceID()).ToString());
                EditorGUILayout.EndHorizontal();
            }
            EditorGUILayout.EndVertical();
        }
        {
            GUI.color = Color.white;
            EditorGUILayout.BeginVertical();
            EditorGUILayout.LabelField("Target: " + customTarget.gameObject.name);
            EditorGUILayout.LabelField("Target: " + customTarget.gameObject.name);
            EditorGUILayout.LabelField("Target: " + customTarget.gameObject.name);
            EditorGUILayout.EndVertical();
        }
    }
}
