using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class svar : MonoBehaviour
{
    public BoxCollider box;
    public GameObject t;
    public GameObject  s;
    // Start is called before the first frame update
    void Start()
    {
      // box = GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tube1")
        {
            Instantiate( s,  t.transform.position,Quaternion.identity) ;
            Instantiate(s, s.transform.position, Quaternion.identity);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
