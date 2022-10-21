using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject krosh;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp = Instantiate(krosh, new Vector3(1, 1, 1), Quaternion.identity);
        if (temp.transform.position.y < -2)
        {
            Debug.Log(transform.position.y);
            Destroy(temp.transform.transform);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Dele")
        {
            Destroy(gameObject);
        }

    }
}
