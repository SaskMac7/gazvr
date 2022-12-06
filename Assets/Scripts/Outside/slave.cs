using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slave : MonoBehaviour
{
    public GameObject EmptyDig;
    public  GameObject lopata;
    public static GameObject dirt;
    public bool isDestr;
    public static bool di;
    void Start()
    {
        
    }

    void Update()
    {
        

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Showel" /*&& isDestr*/ )
        {

            dirt = collision.gameObject;
            di = true;

        }

        if(collision.gameObject.tag == "Hand" )
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
