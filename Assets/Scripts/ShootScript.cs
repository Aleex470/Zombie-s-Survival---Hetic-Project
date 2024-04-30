using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject Munition;
    public float ProjectileSpeed;
    public GameObject ProjectileSpawnPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButtonDown(0))
        {
            GameObject M = Instantiate(Munition);
            M.transform.position = ProjectileSpawnPosition.transform.position;  
            M.transform.rotation = transform.rotation;
            M.GetComponent<Rigidbody>().AddForce(M.transform.forward * ProjectileSpeed);  

        }
    }
}
