using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogsScript : MonoBehaviour, ICollectable {

    public PlayerManager Player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Collect();
        }
    }

    public void Collect()
    {
        Wallet wallet = this.Player.wallet;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Wood;
        Debug.Log("Collected Logs");
        wallet.addResource(resource);
        wallet.getResource(resource);
        Destroy(this.gameObject);
    }
}
