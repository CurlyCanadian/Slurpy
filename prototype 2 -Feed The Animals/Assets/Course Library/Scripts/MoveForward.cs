﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //move speed of the GameObject
    public float speed = 5;


    // Update is called once per frame
    void Update()
    {
    transform.Translate(Vector3.forward * Time.deltaTime * speed); 
     
    }
}
