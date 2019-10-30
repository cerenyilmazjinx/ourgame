using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class PlayerNetworkSetup : NetworkBehaviour {


    public override void OnStartLocalPlayer()
    {
        GetComponent<PlayerControl>().enabled = true;

    }

}

