﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
public class Oscillator2 : MonoBehaviour
{
    
	void Start () {
        
	}

	void Update () {
        transform.Rotate(Vector3.up,Time.deltaTime * 20,Space.World);
	}
}
