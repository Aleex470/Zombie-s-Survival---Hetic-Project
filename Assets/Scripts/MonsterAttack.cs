using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour
{

    public float DelayAttack;
    public int DamageAttack;

    private float _timer = 0;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _timer += Time.deltaTime;
            if ( _timer > DelayAttack)
            {
                other.gameObject.GetComponent<PlayerLifeScript>().UpdateLife(DamageAttack);
                _timer = 0;
            }
        }
    }
}
