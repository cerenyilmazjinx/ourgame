using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomListController : MonoBehaviourPunCallbacks
{
    [HideInInspector]
    public List<RoomInfo> roomList;

    public override void OnEnable()
    {
        roomList = new List<RoomInfo>();

#if UNITY_EDITOR
        if (AppEditorPrefs.UseDebugServer)
        {
            var roomOptions = new RoomOptions();
            PhotonNetwork.JoinOrCreateRoom(AppEditorPrefs.DebugServer, roomOptions, TypedLobby.Default);
            return;
        }
#endif
        PhotonNetwork.GetCustomRoomList(TypedLobby.Default, "");
    }

    public override void OnDisable()
    {
        roomList = new List<RoomInfo>();
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        this.roomList = roomList;
    }

    public override void OnJoinedRoom()
    {
        MasterController.singleton.StartController(MasterController.singleton.lobbyController);
    }
}
