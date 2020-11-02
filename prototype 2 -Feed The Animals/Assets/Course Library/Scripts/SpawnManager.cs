using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20; 

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void start()
    {
        //start SpawnRandomAnimals In 2 seconds(startDelay) with 1.5 Seconds inbetween(spawnInterval)
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        
    }


    void SpawnRandomAnimals()
    {
        //Randomly Generate Animal Index And Spawn Position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0 , -spawnPosZ);

        //Spawn Animal Based Off Of Random Number
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }

}
