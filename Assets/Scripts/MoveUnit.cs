using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUnit : MonoBehaviour
{
    private Renderer renderer;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
    }
}
