using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject Projectile;
    public float ProjectileSpeed;
    public GameObject ProjectileSpawnPosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButtonDown(0))
        {
            GameObject P = Instantiate(Projectile);
            P.transform.position = ProjectileSpawnPosition.transform.position;  
            P.transform.rotation = transform.rotation;
            P.GetComponent<Rigidbody>().AddForce(P.transform.forward * ProjectileSpeed);  

        }
    }
}
