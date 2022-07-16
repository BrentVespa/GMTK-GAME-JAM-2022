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

    public void Collect()
    {
        Wallet wallet = this.Player.wallet;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Rock;
        Debug.Log("Collected Rocks");
        wallet.addResource(resource);
        wallet.getResource(resource);
        Destroy(this.gameObject);

        //player.addRock(10);
        //Other Idea
        //player.addResource(this);
    }
}
/*public void addRock(int rocks)
{
    this.rocks += rocks;
}
Another Idea:
Make a method like add resource in player/lad that takes an ICollectable and determines what
resources to increase based on what reasource was passed in.

Concern: This might negate the point of having the interface to begin with, unless it will not require reworks in player.

public void addResource(ICollectable resource) {
    
}

 */