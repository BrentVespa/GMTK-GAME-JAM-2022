using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksScript : MonoBehaviour, ICollectable {

    public PlayerManager Player;
    

   void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Collect();
        }
    }

    public void Collect() {
        //Set variables
        Wallet wallet = this.Player.wallet;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Rock;

        //Add a number [1-8] of rocks to the player wallet
        wallet.addResource(resource);
        //wallet.getResource(resource);

        //Remove this object from the scene
        Destroy(this.gameObject);
    }
}