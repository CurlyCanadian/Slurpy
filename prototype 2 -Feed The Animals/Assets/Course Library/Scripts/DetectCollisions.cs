using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public float TopBounds = -40.0f;
    public float BottomBounds = 30.0f;
    
    void OnTriggerEnter(Collider other)
    {
        if(transform.position.z > TopBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < BottomBounds)
        {
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
            Time.timeScale = 0;
        }
    }
}
