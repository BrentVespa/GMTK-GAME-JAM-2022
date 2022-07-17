using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToggle : MonoBehaviour
{
    public bool toggled = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            {
            if(toggled == false)
                {
                this.gameObject.SetActive(true);
                toggled = true;
                }
            else if(toggled == true)
                {
                this.gameObject.SetActive(false);
                toggled = false;
                }
            }
    }
}
