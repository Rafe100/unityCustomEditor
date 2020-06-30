using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Runtime.InteropServices;
using System;

[CustomEditor(typeof(CustomTransform))]
public class CustomTransformEditor : Editor
{
    [DllImport("user32.dll")]
    public static extern int MessageBox(IntPtr handle, String message, String title, int type);
    static bool m_showDetails;
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

        {
            GUI.backgroundColor = Color.cyan;
            if (GUILayout.Button("SelectObject"))
            {
                Selection.activeGameObject = GameObject.Find("SelectObject");
            }
            if (GUILayout.Button("MessageBox_0"))
            {
                int result = MessageBox(IntPtr.Zero, "this is a message from ET", "Oh!!!!!!!!!!!!!!", 0);
                Debug.Log("messageBox result " + result);
            }
            if (GUILayout.Button("MessageBox_1"))
            {
                int result = MessageBox(IntPtr.Zero, "this is a message from ET", "Oh!!!!!!!!!!!!!!", 1);
                Debug.Log("messageBox result " + result);
            }
        }

    }
}
