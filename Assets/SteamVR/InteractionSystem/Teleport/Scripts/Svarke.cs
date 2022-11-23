using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Svarke : MonoBehaviour
{
    public float timer;
    public static bool sasa;
    public bool flag;


    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        if (flag && ship.flagship)
        {
            timer = timer + 1 * Time.deltaTime;
            if (timer >= 5)
            {
                sasa = true;
                flag = false;
            }

        }


    }
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "tube1")
        {
            flag = true;

        }
        if (  collision.gameObject.tag == null)
        {
            
            sasa = false;
            timer = 0;
            flag = false;
        }

    }
}
