using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelector : MonoBehaviour
{
    public Camera camera;
    private bool isLifted = false;
    GameObject WhoIsLifted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && WhoIsLifted == null)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) //Where you click it makes a mesh in space within a set amount of units of an object
            {
                if(hit.transform.name != null && hit.transform.tag == "PlayerUnit" && isLifted == false)
                {
                    hit.transform.position = hit.transform.position + Vector3.up;
                    isLifted = true;
                    Debug.Log(hit.transform.position);
                    WhoIsLifted = hit.transform.gameObject;
                }

                
            }
        }

        if ((Input.GetMouseButtonDown(0) && WhoIsLifted != null))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) //Where you click it makes a mesh in space within a set amount of units of an object
            {
                if (hit.transform.name != null && hit.transform.tag == "Ground" && isLifted == true)
                {
                    WhoIsLifted.transform.position = hit.transform.position + (Vector3.up*2.5f);
                    Debug.Log(hit.transform.position);
                    Debug.Log(this.transform.position);
                    WhoIsLifted.transform.position = WhoIsLifted.transform.position - Vector3.up;
                    isLifted = false;
                    WhoIsLifted = null;
                }

                else if (hit.transform.name != null && hit.transform.tag == "NotGround" && isLifted == true)
                {
                    Debug.Log("Error Invalid Location");
                }
            }
        }

    }
}
