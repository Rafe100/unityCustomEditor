using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomSelection : MonoBehaviour
{
    [MenuItem("Custom/CustomSelection")]
    public static void CustomSelet()
    {
        if (Selection.objects == null)
        {
            Debug.Log("Selection.objects is null");
            return;
        }
        if (Selection.objects.Length == 0)
        {
            Debug.Log("Selection.objects Length is zero");
            return;
        }
        for(int i = 0;i < Selection.objects.Length;i++)
        {
            var o = Selection.objects[i];
            Debug.Log("Selection.objects is " + o);
        }
        Debug.Log("Selection.activeInstanceID is " + Selection.activeInstanceID);
        Debug.Log("Selection.activeContext is " + Selection.activeContext);
        Debug.Log("Selection.activeObject is " + Selection.activeObject);
        Debug.Log("Selection.activeGameObject is " + Selection.activeGameObject);
        Debug.Log("Selection.activeTransform is " + Selection.activeTransform);
        for (int i = 0; i < Selection.gameObjects.Length; i++)
        {
            var o = Selection.gameObjects[i];
            Debug.Log("Selection.gameObjects is " + o);
        }
        for (int i = 0; i < Selection.transforms.Length; i++)
        {
            var o = Selection.transforms[i];
            Debug.Log("Selection.transforms is " + o);
        }
        for (int i = 0; i < Selection.instanceIDs.Length; i++)
        {
            var o = Selection.instanceIDs[i];
            Debug.Log("Selection.instanceIDs is " + o);
        }
        for (int i = 0; i < Selection.assetGUIDs.Length; i++)
        {
            var o = Selection.assetGUIDs[i];
            Debug.Log("Selection.assetGUIDs is " + o);
        }
    }
}
