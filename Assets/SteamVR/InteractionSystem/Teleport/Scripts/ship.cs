using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public static bool flagship;
    public  bool fla;
    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "tube1")
        {
            flagship = true;
            fla = true;
        }
        if (collision.gameObject.tag != "tube1" || collision.gameObject.tag == null)
        {
            flagship = false;
            fla = false;
        }
    }
   
}