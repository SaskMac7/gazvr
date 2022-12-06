using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prisosa : MonoBehaviour
{
    public GameObject a;
    public GameObject s;
    // Start is called before the first frame update

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, a.transform.position) <= 0.5f)
        {
            a.SetActive(true);

        }
        else
        a.SetActive(false);
        if ( s.transform.position != gameObject.transform.position)
        {
            a.GetComponent<MeshRenderer>().enabled = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "tube1")
        {
            gameObject.transform.position = other.gameObject.transform.position;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.transform.rotation = other.gameObject.transform.rotation;
            s = other.gameObject;

        }
        
       
    }

}
