using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //vari
    public float speed = 20.0f;
    public float xRange = 25.0f;
    public float zRange = 25.0f;

    //public float TopBounds = -10.0f;
    //public float BottomBounds = 10.2f;

    public float horizontalInput;
    public float VerticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");  
        // moves the player forward??
        transform.Translate(Vector3.forward * VerticalInput * Time.deltaTime * speed);

        //controls player movement left to right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    
        //keeps player in boudary --left
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
    
        //keeps player in boudary --Right
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        //keeps player in boudary --Bottom
        if(transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }
        //keeps player in boudary --Top
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
