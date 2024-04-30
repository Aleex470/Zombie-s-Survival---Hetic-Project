using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunitionScript : MonoBehaviour
{
    public int munitionsTotales = 6; 
    public float delaiRechargement = 3.0f; 

    private int munitionsRestantes; 
    private bool isReloading = false;

    public GameObject Projectile;
    public float ProjectileSpeed;
    public GameObject ProjectileSpawnPosition;


    void Start()
    {
        munitionsRestantes = munitionsTotales;
    }

    // Fonction pour tirer
    public void Tirer()
    {
        if (!isReloading && munitionsRestantes > 0)
        {
            if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButtonDown(0))
            {
                GameObject P = Instantiate(Projectile);
                P.transform.position = ProjectileSpawnPosition.transform.position;
                P.transform.rotation = transform.rotation;
                P.GetComponent<Rigidbody>().AddForce(P.transform.forward * ProjectileSpeed);

            }

            munitionsRestantes--;
            Debug.Log("Pew! Il reste " + munitionsRestantes + " munitions.");
            // Mettez ici le code pour l'animation de tir
            if (munitionsRestantes == 0)
            {
                StartCoroutine(Rechargement());
            }
        }
        else
        {
            Debug.Log("Plus de munitions ou en train de recharger!");
        }
    }

    // Fonction pour recharger
    IEnumerator Rechargement()
    {
        isReloading = true;
        Debug.Log("Rechargement en cours...");
        // Mettez ici le code pour l'animation de rechargement
        yield return new WaitForSeconds(delaiRechargement);
        munitionsRestantes = munitionsTotales;
        isReloading = false;
        Debug.Log("Rechargement terminé! Vous avez " + munitionsRestantes + " munitions.");
    }
}

