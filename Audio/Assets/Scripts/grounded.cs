using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounded : MonoBehaviour
{
    [HideInInspector]
    public string groundType;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        groundType = "None";
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Stone")
        {
            groundType = "Stone";
        }
        else
        {
            groundType = "Wood";
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "Stone")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" || collision.gameObject.tag == "Stone")
        {
            isGrounded = false;
        }
    }
}
