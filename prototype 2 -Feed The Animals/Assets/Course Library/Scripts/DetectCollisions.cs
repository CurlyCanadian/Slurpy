using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    
    void OnTriggerEnter(Collider other)
    {
        if(transform.position.z < TopBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z > BottomBounds)
        {
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
            Time.timeScale = 0;
        }
    }
}
