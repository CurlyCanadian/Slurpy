using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 200.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        //collect input data on horizontal controls
        horizontalInput = Input.GetAxis("Horizontal");
        //moves the player to the left and right
        transform.Translate(Vector3.right * -horizontalInput * Time.deltaTime * speed);

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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
