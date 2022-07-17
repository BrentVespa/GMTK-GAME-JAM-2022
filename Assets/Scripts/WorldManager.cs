using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    //private int? spawnDice()
    //{
    //    if (DiceDroped == false)
    //    {
    //        GameObject Die = Instantiate(D8Prefab) as GameObject;
    //        Die.transform.position = DiceBox.transform.position + (Vector3.up * 5);
    //        DiceDroped = true;
    //    }
    //    value = D8Prefab.GetComponentInChildren<SideName>().side;
    //    Debug.Log(value);

    //    if (value != null && isCoroutineExecuting) {
    //        DiceDroped = false;
    //        Debug.Log(value);
    //        state = ActionState.PROCESS;
    //        return value;
    //    }
    //    return null;
    //}

    private void MoveRadius()
    {
        //renderer.material.color = Color.red;
    }
}
