using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePreFab;
    private Vector3 spawnPos = new Vector3(25, .5f, .5f);
    
    private float startDelay = 1;
    private float repeatDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);

    }

    void SpawnObstacle()
    {
        Instantiate(ObstaclePreFab, spawnPos, ObstaclePreFab.transform.rotation);
    
    }
    // Update is called once per frame
    void Update()
    {

    }
}
