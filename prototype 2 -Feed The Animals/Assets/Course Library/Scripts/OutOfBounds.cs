using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float TopBounds = 33.0f;
    public float BottomBounds = -20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > TopBounds)
        {
            Destroy(gameObject);
        }
        if(transform.position.z < BottomBounds)
        {
            Destroy(gameObject);
        }

    }
}
