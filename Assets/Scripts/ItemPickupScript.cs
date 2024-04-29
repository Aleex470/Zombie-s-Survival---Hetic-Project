using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemPickupScript : MonoBehaviour
{
    public GameObject Canvas;

    private bool CanBePickup = false;

    private void Update()
    {
        if (CanBePickup && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            // le mettre dans une variable
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Canvas.SetActive(true);
            CanBePickup = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Canvas.SetActive(false);
            CanBePickup = false;

        }
    }
}
