using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogsScript : MonoBehaviour, ICollectable {

    public PlayerManager Player;
    public GameObject TopHat;

    public AudioClip audioFile;

    [Header("Grab Dist")]
    [Range(0f, 20.0f)]
    public float dist;

    void Start()
    {
        TopHat = GameObject.FindGameObjectWithTag("UnitOne");
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.LeftControl) && Vector3.Distance(this.gameObject.transform.position, TopHat.transform.position) < dist))
        {
            Debug.Log("Got Into Log Collect");
            //this.GetComponent<AudioSource>().Play();
            AudioSource.PlayClipAtPoint(audioFile, transform.position);
            Collect();

        }
    }

    public void Collect() {
        //Set variables
        Wallet wallet = this.Player.wallet;
        ResourceTypes.Resource resource = ResourceTypes.Resource.Wood;

        //Add a number [1-8] of rocks to the player wallet
        wallet.addResource(resource);
        //wallet.getResource(resource);

        //Remove this object from the scene
        Destroy(this.gameObject);
    }
}
