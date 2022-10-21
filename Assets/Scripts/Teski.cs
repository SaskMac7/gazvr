using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teski : MonoBehaviour
{
    public Vector3 constPos;
    void Start()
    {
        constPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
       
    }

    void Update()
    {
        transform.position = constPos;
    }
}
