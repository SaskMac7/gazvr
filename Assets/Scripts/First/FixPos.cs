using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPos : MonoBehaviour
{
    public GameObject tube;
    public Rigidbody rbTube;
    private bool znak;

    public GameObject targetPos;
    void Start()
    {
        rbTube = tube.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (znak == true)
        {
            tube.transform.position = targetPos.transform.position;
            rbTube.constraints = RigidbodyConstraints.FreezeRotation;
            tube.transform.rotation = Quaternion.Euler(0, 90, 0); 
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        
        tube = collision.gameObject;
        znak = true;
        
       /* if(collision.gameObject.tag == "tube1")
        {
            tube = 
           *//* tube.transform.position = targetPos.transform.position;
            rbTube.constraints = RigidbodyConstraints.FreezePosition;
            rbTube.constraints = RigidbodyConstraints.FreezeRotation;*//*
            
        }*/
    }
}
