using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loss : MonoBehaviour
{
    public GameObject first;
    public Rigidbody rb;
    public Rigidbody Frb;
    public Rigidbody Srb;
    public GameObject second;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Rigidbody Frb = first.GetComponent<Rigidbody>();
        Rigidbody Srb = second.GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            first.gameObject.transform.SetParent(null);
            second.gameObject.transform.SetParent(null);
            Frb.useGravity = true;
            Srb.useGravity = true;
            Frb.isKinematic = false;
            //Frb.detectCollisions = false;
            Srb.isKinematic = false;
            //Srb.detectCollisions = false;
        }
    }


}
