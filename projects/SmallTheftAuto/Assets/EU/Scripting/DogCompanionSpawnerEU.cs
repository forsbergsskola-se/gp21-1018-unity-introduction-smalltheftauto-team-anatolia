using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerEU : MonoBehaviour
{
    public GameObject DogPrefab;
    // Start is called before the first frame update
    void OnEnable()
    {
        Instantiate(DogPrefab);
        Debug.Log("im AWAke lol");
    }

    // Update is called once per frame
    void OnDisable()
    {
        Destroy(DogPrefab);
        Debug.Log("Im gone lol");
    }
}
