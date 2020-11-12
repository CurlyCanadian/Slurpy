using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5;


    // Update is called once per frame
    void Update()
    {
        //Moves The GameObject
        transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
