using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slave : MonoBehaviour
{
    public GameObject EmptyDig;

    public bool isDestr;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Showel" && isDestr == true)
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Hand")
        {
            isDestr = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Hand")
        {
            isDestr = false;
        }
    }



}
