using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lopata : MonoBehaviour
{
    private GameObject dirt;
    private bool di;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(di)
        {
            dirt.transform.position = gameObject.transform.position; 



        }
        if(transform.forward.y < 0)
        {
            Destroy(dirt);
        }

    }
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "Showel" )
        {

            dirt = collision.gameObject;
            di = true;

        }

        
    }
}
