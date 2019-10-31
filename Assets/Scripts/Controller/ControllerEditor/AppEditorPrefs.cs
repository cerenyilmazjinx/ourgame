
#if UNITY_EDITOR

using UnityEditor;

public static class AppEditorPrefs
{
    private const string debugServerKey = "debugServerKey";
    public static string DebugServer
    {
        get { return EditorPrefs.GetString(debugServerKey); }
        set { EditorPrefs.SetString(debugServerKey, value); }
    }

    private const string useDebugServerKey = "useDebugServerKey";
    public static bool UseDebugServer
    {
        get { return EditorPrefs.GetBool(useDebugServerKey); }
        set { EditorPrefs.SetBool(useDebugServerKey, value); }
    }

}

#endif