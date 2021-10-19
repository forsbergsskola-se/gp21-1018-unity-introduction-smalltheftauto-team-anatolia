using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerCSR : MonoBehaviour
{
    public GameObject DogPrefab;
    private GameObject DogInstance;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        DogInstance = Instantiate(DogPrefab);
    }

    // Update is called once per frame
    void OnDisable()
    {
        Destroy(DogPrefab);
    }
}