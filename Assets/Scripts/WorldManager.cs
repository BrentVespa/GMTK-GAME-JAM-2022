using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{    
    public GameObject RockPrefab;
    public GameObject WoodPrefab;

    [Header("Random Range")]
    [Range(-50.0f, 0f)]
    public float xVectorMin;
    [Range(0f, 50.0f)]
    public float xVectorMax;
    [Range(0, 20.0f)]
    public float yVector = 20f;
    [Range(-50.0f, 0f)]
    public float zVectorMin = -20f;
    [Range(0f, 50.0f)]
    public float zVectorMax = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRock", Random.Range(5, 10));
        Invoke("SpawnWood", Random.Range(5,10));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnRock()
    {
        {
            Vector3 RandomPos = transform.position + new Vector3(Random.Range(xVectorMin, xVectorMax), yVector, Random.Range(zVectorMin, zVectorMax));
            Instantiate(RockPrefab, RandomPos, Quaternion.identity);
            
            //Debug.Log("Spawned Rock");
        }
        Invoke("SpawnRock", Random.Range(5, 10));
    }

    public void SpawnWood()
    {
        {
            Vector3 RandomPos = transform.position + new Vector3(Random.Range(xVectorMin, xVectorMax), yVector, Random.Range(zVectorMin, zVectorMax));
            Instantiate(WoodPrefab, RandomPos, Quaternion.identity);

            //Debug.Log("Spawned Wood");
        }
        Invoke("SpawnWood", Random.Range(5, 10));
    }

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
