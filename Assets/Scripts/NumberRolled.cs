using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberRolled : WorldManager
{
    public GameObject[] sides;

    public GameObject WorldEventManager;

    Rigidbody body;
    string name;
    GameObject low;
    public int value;
    float smallestDist = Mathf.Infinity; //starting distance, everything is smaller than infinity

    // Start is called before the first frame update
    void Start()
    {
        //sides = GameObject.FindGameObjectsWithTag("D8 Side");
        sides = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            sides[i] = transform.GetChild(i).gameObject;
        }

        body = GetComponent<Rigidbody>();

    }

    public int Roll()
    {
        float y = body.velocity.y;
        float x = body.velocity.x;

        Debug.DrawRay(this.transform.position, -(transform.position-new Vector3(0,10,0)), Color.yellow);

        foreach(GameObject s in sides)
        {
            Vector3 UpPoint = this.transform.position + (Vector3.up * 3); // used to calc toTop
            float toTop = Vector3.Distance(s.transform.position, UpPoint); //Point above dice
            if (toTop < smallestDist)
            {
                smallestDist = toTop;
                low = s;
                name = this.gameObject.name;
            }
            else
            {
                Debug.Log("Error in toTop < smallestDist");
            }
        }

        value = low.GetComponentInChildren<SideName>().side;
        Debug.Log("Dice: " + name + " TopSide is: " + low + "Value: " + value);

        WorldEventManager.GetComponent<WorldManager>().WorldEventValue = value;

        return WorldEventValue;
    }


    // Update is called once per frame
    void Update()
    {
        if((body.velocity.x == 0 && body.velocity.y == 0))
        {
        Roll();
        }
    }
}
