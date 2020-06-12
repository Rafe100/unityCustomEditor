using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomMenuItem : MonoBehaviour
{
    [MenuItem("Custom/CustomMenuItem")]
    public static void CusMenuItem()
    {
        Debug.Log("CusMenuItem");
    }
}
