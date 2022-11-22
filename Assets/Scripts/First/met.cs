using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class met : MonoBehaviour
{
    
    private bool flag;
    private GameObject gam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            gameObject.transform.position = gam.transform.position;
            

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "met")
        {
            flag = true;
            gam = other.gameObject;
        }
    }
}
