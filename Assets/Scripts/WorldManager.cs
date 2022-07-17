using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{    
    public GameObject player;
    public GameObject Dice;
    
    public int WorldEventValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("spawnDice", 1);
        //Invoke("DestroyDie", 20);
    }

    // Update is called once per frame
    void Update()
    {
        //Invoke("DestroyDie", 120);
        //Invoke("spawnDice", 120);
    }
    //public void spawnDice()
    //{
    //        GameObject Die = Instantiate(Dice) as GameObject;
    //        Die.transform.position = player.transform.position + new Vector3(Random.Range(1, 5), 0, Random.Range(1, 5));
    //        Invoke("WaitForIt", 2);
    //}

    //public void DestroyDie()
    //{
    //    DestroyImmediate(Dice, true);
    //}

    //public int WaitForIt()
    //{
    //    WorldEventValue = Dice.GetComponent<NumberRolled>().value;
    //    return WorldEventValue;
    //}
}
