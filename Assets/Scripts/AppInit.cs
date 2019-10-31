using UnityEngine;

public static class AppInit
{
    [RuntimeInitializeOnLoadMethod]
    static private void Init()
    {
        var prefab = Resources.Load<GameObject>("Prefabs/MasterController");
        var masterController = GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity);
        masterController.name = "Master Controller";
    }
}
