using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public Transform theDest;
    public bool isHolding;
    public bool hasKey;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            isHolding = !isHolding;
        }

        if(isHolding)
        {
            GetComponent<SphereCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Player").transform;
            hasKey = true;
        }
        else
        {
            this.transform.parent = null;
            GetComponent<SphereCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            hasKey = false;
        }
    }
}
