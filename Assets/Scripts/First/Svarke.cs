using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svarke : MonoBehaviour
{
    public float timer;
    public  static bool sasa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.tag == "tube1")
        {
            timer = timer + 1 * Time.deltaTime;
            if(timer >= 5)
            {
                sasa = true; 
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        sasa = false;
        timer = 0;

       
    }
}
