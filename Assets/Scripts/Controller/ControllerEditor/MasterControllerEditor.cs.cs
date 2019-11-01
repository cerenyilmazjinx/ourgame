
#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MasterController))]
public class MasterControllerEditor : Editor
{
    void OnEnable()
    {
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Space(10);

        AppEditorPrefs.UseDebugServer = EditorGUILayout.Toggle("UseDebugServer", AppEditorPrefs.UseDebugServer);
        AppEditorPrefs.DebugServer = EditorGUILayout.TextField("DebugServer", AppEditorPrefs.DebugServer);

    }
}

#endif