using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChechpointScript : MonoBehaviour
{

    public GameObject RespawnPosition;

    public static Vector3 CurrentRespawnPosition;

    private void OnTriggerEnter(Collider other)
    {
        CurrentRespawnPosition = RespawnPosition.transform.position;
        PlayerPrefs.SetFloat("respawnPosX" , CurrentRespawnPosition.x);
        PlayerPrefs.SetFloat("respawnPosY" , CurrentRespawnPosition.y);
        PlayerPrefs.SetFloat("respawnPosZ" , CurrentRespawnPosition.z);
    }

    private void Start()
    {
        CurrentRespawnPosition = new Vector3 (PlayerPrefs.GetFloat("respawnPosX"), PlayerPrefs.GetFloat("respawnPosY"), PlayerPrefs.GetFloat("respawnPosZ"));
    }

}
