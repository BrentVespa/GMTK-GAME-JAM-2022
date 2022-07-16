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
        Debug.Log("Collected Logs");
        Destroy(this.gameObject);
    }
}
