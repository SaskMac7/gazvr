using System.Collections;

using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Thing : MonoBehaviour
{
    public Renderer qq;
    private Interactable interactable;
    private SteamVR_Input_Sources hand;

    public GameObject megaTube;
    public GameObject testObj;

    public TextMesh generalText;

    public bool flag;
    public bool flag2;
    public bool flagCol;

    public
    void Start()
    {
        Debug.Log("123");
        interactable = GetComponent<Interactable>();
    }

    void Update()
    {
/*        if (interactable.attachedToHand)
        {
            hand = interactable.attachedToHand.handType;
            flag = true;
            Debug.Log("Взял", hand.name);
        }
        else
        {
            flag = false;
        }*/

    }
    private void OnAttachedToHand(Hand hand)
    {
        if (hand.name == "LeftHand")
        {
            generalText.text = "Взял в левую руку";
            qq.enabled = true;
        }

        if (hand.name == "RightHand")
        {
            generalText.text = "Взял в правую руку";
            qq.enabled = true;
        }

        flag = true;
        Debug.Log("Взял");
        Debug.Log(hand.name);
    }

    private void OnDetachedFromHand(Hand hand)
    {
        flag = false;
    }

    private void OnHandHoverBegin(Hand hand)
    {
        
        if(hand.name == "LeftHand")
        {
            generalText.text = "Дотронулся левой рукой";
        }

        if (hand.name == "RightHand")
        {
            generalText.text = "Дотронулся правой рукой";
        }

        flag2 = true;
        Debug.Log("Дотронулся");
        Debug.Log(hand.name);
    }

    private void OnHandHoverEnd(Hand hand)
    {
        flag2 = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tube1")
        {
            gameObject.transform.SetParent(testObj.transform);
            collision.gameObject.transform.SetParent(testObj.transform);

            //соеденинение префаба
            Instantiate(
                megaTube,
                new Vector3(transform.position.x, transform.position.y, transform.position.z),
                Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            flagCol = true;

        }
    }

}
