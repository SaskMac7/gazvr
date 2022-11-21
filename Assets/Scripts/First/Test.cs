using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Test : MonoBehaviour
{
    public GameObject handleObj;
    void Start()
    {
       
    }


    void Update()
    {
        
    }

    private void OnAttachedToHand(Hand hand)
    {
        transform.eulerAngles += new Vector3(1, 0, 0);
    }
}
