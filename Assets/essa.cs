using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class essa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x, 0, z);
        Debug.Log(movement);
    }
}
