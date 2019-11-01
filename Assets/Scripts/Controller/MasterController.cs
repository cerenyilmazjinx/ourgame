using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MasterController : MonoBehaviour
{
    public static MasterController singleton;

    public InGameController inGameController;
    public InitController initController;
    public LobbyController lobbyController;
    public RoomListController roomListController;

    private List<MonoBehaviour> controllers;
    void Start()
    {
        singleton = this;

        controllers = new List<MonoBehaviour>{
            inGameController,
            initController,
            lobbyController
        };

        StartController(initController);
    }

    void Update()
    {

    }

    public void StartController(MonoBehaviour startController)
    {
        controllers.ForEach(c => c.gameObject.SetActive(c == startController));
    }

}
