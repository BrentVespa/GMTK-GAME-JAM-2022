using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public GameObject TimerUp;

    public int Time = 0;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("UpdateTimer", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTimer()
    {
        Time++;
        //Debug.Log(Time);
        TimerUp.GetComponent<TMPro.TextMeshProUGUI>().text = Time.ToString();
        //Debug.Log("Updated Text");
        //System.Convert.ToUInt32(Time);
        Invoke("UpdateTimer", 1);
    }
}
