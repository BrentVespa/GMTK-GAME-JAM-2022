using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    GameObject[] agentsOne;
    GameObject[] agentsTwo;

    private Renderer renderer;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        agentsOne = GameObject.FindGameObjectsWithTag("UnitOne");
        agentsTwo = GameObject.FindGameObjectsWithTag("UnitTwo");
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && this.transform.tag == "UnitOne")
        {
            RaycastHit hit;
            
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10000))
            {
                foreach (GameObject a in agentsOne)
                {
                    {
                        a.GetComponent<PlayerController>().agent.SetDestination(hit.point);
                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(1) && this.transform.tag == "UnitTwo")
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 10000))
            {
                foreach (GameObject a in agentsTwo)
                {
                    a.GetComponent<PlayerController>().agent.SetDestination(hit.point);
                }
            }
        }
    }

    //private void OnMouseEnter()
    //{
    //    renderer.material.color = Color.red;
    //}

    //private void OnMouseExit()
    //{
    //    renderer.material.color = Color.white;
    //}
}
