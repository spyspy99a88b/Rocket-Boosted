using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-Vector3.up,Time.deltaTime * 10,Space.World);
    }
}
