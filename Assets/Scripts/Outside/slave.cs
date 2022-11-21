using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slave : MonoBehaviour
{
    public GameObject EmptyDig;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Showel")
        {
            Instantiate(
                EmptyDig,
                new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z),
                Quaternion.identity);
        }

    }
}
