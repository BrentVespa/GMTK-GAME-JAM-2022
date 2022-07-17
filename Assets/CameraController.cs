using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;

    [Header("View Angle")] 
    [Range(-20.0f, 20.0f)]
    public float xVector;
    [Range(-20.0f, 20.0f)]
    public float yVector;   
    [Range(-20.0f, 20.0f)]
    public float zVector;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(xVector, yVector, zVector);
    }
}
