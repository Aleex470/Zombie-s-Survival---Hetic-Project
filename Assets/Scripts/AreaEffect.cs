using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffect : MonoBehaviour
{
    public float BumperForce;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Transform>().localScale /= 2;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, BumperForce, 0));
        other.gameObject.GetComponent<PlayerControler>().Speed *= 2;
    }
}
