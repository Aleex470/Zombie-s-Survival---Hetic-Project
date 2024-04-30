using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject ZombiePrefab;
    public GameObject[] ZombieSpawnPositions;

    public int maxZombies = 5;
    private List<GameObject> zombies = new List<GameObject>();
    private float _timer = 0;

    private void SpawnZombie()
    {
        GameObject zombie = Instantiate(ZombiePrefab);
        zombie.transform.position = ZombieSpawnPositions[Random.Range(0, ZombieSpawnPositions.Length)].transform.position;
        zombie.GetComponent<SqueletonScript>().Target = Player;

        zombies.Add(zombie);
    }

    void Update()
    {

        _timer += Time.deltaTime;

        // Si le nombre de zombies actifs est inférieur au maximum autorisé, en instancie un nouveau
        if (zombies.Count < maxZombies && _timer > 1)
        {
            SpawnZombie();
            _timer = 0;
        }
        // Vérifie si des zombies ont été détruits et les supprime de la liste
        for (int i = zombies.Count - 1; i >= 0; i--)
        {
            if (zombies[i] == null)
            {
                zombies.RemoveAt(i);
            }
        }
    }
}
