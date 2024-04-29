using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject ObjectToShrink;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        collision.gameObject.GetComponent<Transform>().localScale *= 2;

        ObjectToShrink.GetComponent<Transform>().localScale /= 2;

        //collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,1000,0));
    }
}
