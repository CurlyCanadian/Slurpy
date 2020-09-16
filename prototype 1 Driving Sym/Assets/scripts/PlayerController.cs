using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 40;
    public float turnSpeed;
    //side controlles
    public float horizontalInput;
    //move forward
    public float verticalInput;
    //jump?
    public float jumpInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //side controlles
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);       
        
        // moves vehicle forward
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime *speed * verticalInput);
        
        
        //jump
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * speed * jumpInput);
    }
}
