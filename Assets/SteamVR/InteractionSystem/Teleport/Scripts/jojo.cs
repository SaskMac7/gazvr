
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class jojo : MonoBehaviour
{
    // public FixedJoint fj;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {

        //Rigidbody rb = gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (Svarke.sasa && collision.gameObject.tag == "tube1" && i == 0)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>() as FixedJoint;
            fj.connectedBody = collision.rigidbody;
            i++;
        }
    }
}
