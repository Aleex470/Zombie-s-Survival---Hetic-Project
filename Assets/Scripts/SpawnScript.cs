using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject Potion;

    private float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;

        if ( _timer > 1 )
        {
            GameObject g = Instantiate(Potion);
            g.GetComponent<Transform>().position = GetComponent<Transform>().position;
            g.GetComponent<Rigidbody>().AddForce(new Vector3(100, 100, 0));
            Destroy(g, 2);
            _timer = 0;
        }
    }
}
