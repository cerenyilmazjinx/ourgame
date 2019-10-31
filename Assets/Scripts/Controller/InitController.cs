using Photon.Pun;
using UnityEngine;

public class InitController : MonoBehaviourPunCallbacks
{
    void Start()
    {
    }

    void Update()
    {
    }

    public override void OnEnable()
    {
        if (!PhotonNetwork.IsConnected)
        {
            Debug.Log("PhotonNetwork.ConnectUsingSettings()");
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnDisable()
    {

    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster");
        MasterController.singleton.StartController(MasterController.singleton.roomListController);
    }
}
