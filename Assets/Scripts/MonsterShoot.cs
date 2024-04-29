using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShoot : MonoBehaviour
{

    public GameObject Projectile;
    public GameObject StartPositionProjectile;
    public float Strength;
    private float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 3 && Vector3.Distance(GetComponent<SqueletonScript>().Target.transform.position, transform.position) < 50)
        {
            GameObject p = Instantiate(Projectile);
            p.transform.position = StartPositionProjectile.transform.position;
            Vector3 dir = GetComponent<SqueletonScript>().Target.transform.position - transform.position;
            dir = dir.normalized;
            p.GetComponent<Rigidbody>().AddForce(dir * Strength);
            _timer = 0;
        }
    }
}
