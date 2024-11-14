using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    int startDelay = 2;
    float repeatInterval = 1.5f;
    float spawnRangeX = 15;
    float spawnPosz = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, repeatInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosz);
        Instantiate (animalPrefabs[animalIndex], new Vector3(), animalPrefabs[animalIndex].transform.rotation);
    }
            
}
