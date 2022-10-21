using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
//[RequireComponent(typeof(FixedJoint))]
public class TeskiMain : MonoBehaviour
{
    public GameObject collisObj;
    public FixedJoint fj;

   
    public Transform fixPos;
    void Start()
    {
        fj = GetComponent<FixedJoint>();
        
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Teski")
        {
            gameObject.transform.position = new Vector3(fixPos.position.x, fixPos.position.y, fixPos.position.z);
            //gameObject.transform.rotation = (0, 90, 0);
            //gameObject.transform.Rotate(0.0f, 90.0f, 0.0f);
        }
        if (collision.gameObject.tag == "Truba")
        {
            fj.connectedBody = collision.rigidbody;
        }
        if (collision.gameObject.tag == "pila")
        {
            fj.connectedBody = null;
            fj = null;
            Destroy(GetComponent<FixedJoint>());


        }

    }
 
}
