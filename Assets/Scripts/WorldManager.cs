using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject D8Prefab;
    public GameObject DiceBox;
    public bool PTurn = true;
    int? value = null;
    bool DiceDroped = false;

    private bool isCoroutineExecuting = false;
    public enum ActionState {START, PROCESS, END};
    ActionState state = ActionState.START;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(PTurn)
        {
            PlayerTurn();
        }
        else
        {
            //ETurn();
        }
        
    }

    void PlayerTurn()
    {
        if (state == ActionState.START)
        {
            spawnDice();
            StartCoroutine(ExecuteAfterTime(30));
        }

        if (state == ActionState.PROCESS)
        {
            Debug.Log("Dice Rolled: " + value);
            Debug.Log("Processing");
        }

        if (state == ActionState.END)
        {
            PTurn = false;
            state = ActionState.START;
        }
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        if (isCoroutineExecuting)
            yield break;

        isCoroutineExecuting = true;

        yield return new WaitForSeconds(time);

        if (value != null)
        {
            state = ActionState.PROCESS;
        }

        isCoroutineExecuting = false;
    }

    private int? spawnDice()
    {
        if (DiceDroped == false)
        {
            GameObject Die = Instantiate(D8Prefab) as GameObject;
            Die.transform.position = DiceBox.transform.position + (Vector3.up * 5);
            DiceDroped = true;
        }
        value = D8Prefab.GetComponentInChildren<SideName>().side;
        Debug.Log(value);

        if (value != null && isCoroutineExecuting) {
            DiceDroped = false;
            Debug.Log(value);
            state = ActionState.PROCESS;
            return value;
        }
        return null;
    }

    private void MoveRadius()
    {
        //renderer.material.color = Color.red;
    }
}
