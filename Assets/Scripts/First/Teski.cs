using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teski : MonoBehaviour
{
    public Vector3 constPos;
    public Vector3 constRot;
    void Start()
    {
        constPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        constRot = new Vector3(transform.rotation.x, -90, transform.rotation.z);
       
    }

    void Update()
    {
        transform.position = constPos;

        Debug.Log(transform.position.x);
        Debug.Log(transform.position.y);
        if (transform.rotation.x < -1)
        {
            transform.eulerAngles = new Vector3(constRot.x, constRot.y, transform.rotation.z);
        }

        if (transform.rotation.x > 1)
        {
            transform.eulerAngles = new Vector3(constRot.x, constRot.y, transform.rotation.z);
        }

        if (transform.rotation.y < -1)
        {
            transform.eulerAngles = new Vector3(constRot.x, constRot.y, transform.rotation.z);
            Debug.Log("111111111111111111111");
        }

        if (transform.rotation.y > 1)
        {

            transform.eulerAngles = new Vector3(constRot.x, constRot.y, transform.rotation.z);
            Debug.Log("111111111111111111111");
        }
    }
}
