using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MasterController : MonoBehaviour
{
    public InGameController inGameController;
    public InitController initController;
    public LobbyController lobbyController;

    private List<MonoBehaviour> controllers;
    void Start()
    {
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
