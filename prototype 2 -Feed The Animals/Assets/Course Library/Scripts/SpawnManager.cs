using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;

    // Update is called once per frame
    void Update()
    {
        if(input.GetKeyDown(KeyCode.S))      
        {
            Instatiate(animalPrefabs[animalIndex], new Vetor3(0,0,-20), animalPrefabs[animalIndex].transform.rotation);
        }  
    }
}
