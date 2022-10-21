using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class NewBehaviorScript : MonoBehaviour
{
    private Interactable interactable;
    private SteamVR_Input_Sources hand;
    public bool flag;
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    void Update()
    {
        if (interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
            flag = true;
        }
        else
        {
            flag = false;
        }
    }
}
