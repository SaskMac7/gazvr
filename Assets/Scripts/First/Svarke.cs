using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svarke : MonoBehaviour
{
    public float timer;
    public  bool sasa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollision(Collision collision)
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
}
