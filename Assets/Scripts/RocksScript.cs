using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksScript : MonoBehaviour, ICollectable
{  
   void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            Collect();
        }
    }

    public void Collect()
    {
        Debug.Log("Collected Rocks");
        Destroy(this.gameObject);

        //player.addRock(10);
    }
}
/*public void addRock(int rocks)
{
    this.rocks += rocks;
}*/