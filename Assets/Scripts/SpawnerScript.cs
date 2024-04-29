using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject ZombiePrefab;
    public GameObject[] ZombieSpawnPositions;

    private float _timer = 0;

    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 1)
        {
            GameObject zombie = Instantiate(ZombiePrefab);
            zombie.transform.position = ZombieSpawnPositions[Random.Range(0, ZombieSpawnPositions.Length)].transform.position;
            zombie.GetComponent<SqueletonScript>().Target = Player; 
            _timer = 0;
        }
    }
}
