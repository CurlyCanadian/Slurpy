using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20; 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))      
        {
            //Randomly Generate Animal Index And Spawn Position
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0 , -spawnPosZ);

            //Spawn Animal Based Off Of Random Number
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }  
    }
}
