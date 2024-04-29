using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;
    public float JumpForce;

    private int _nbObjectUnderFeet = 0;

    public GameObject AnimatorCharacter;
    private void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-GetComponent<Transform>().right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-GetComponent<Transform>().forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward * Speed * Time.deltaTime);
        }
        if ( Input.GetKey(KeyCode.Q))
        {
            GetComponent<Transform>().Rotate(new Vector3(0, -RotationSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Transform>().Rotate(new Vector3(0, RotationSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && _nbObjectUnderFeet > 0)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = ChechpointScript.CurrentRespawnPosition;
        }

        AnimatorCharacter.GetComponent<Animator>().SetFloat("Speed", GetComponent<Rigidbody>().velocity.magnitude);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
            _nbObjectUnderFeet++;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
            _nbObjectUnderFeet--;
    }
}
