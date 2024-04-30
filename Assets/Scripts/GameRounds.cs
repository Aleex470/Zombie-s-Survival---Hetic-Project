using System.Collections;
using UnityEngine;

public class GameRounds : MonoBehaviour
{
    public int zombiesToKillPerRound = 10;
    private int currentZombiesKilled = 0;
    private int currentRound = 1;

    private bool isRoundActive = false;
    private bool isGameOver = false;

    void Start()
    {
        StartNextRound();
    }

    void Update()
    {
        if (isGameOver)
        {
            Debug.Log("Le jeu est terminé !");
            return;
        }
        if (isRoundActive && currentZombiesKilled >= zombiesToKillPerRound)
        {
            StartCoroutine(StartNextRoundWithDelay());
        }
    }

    IEnumerator StartNextRoundWithDelay()
    {
        isRoundActive = false;

        yield return new WaitForSeconds(3f);

        currentRound++;

        if (currentRound > 10)
        {
            isGameOver = true;
            Debug.Log("Félicitations ! Vous avez terminé les 10 manches.");
            yield break;
        }

        currentZombiesKilled = 0;
        StartNextRound();
    }

    void StartNextRound()
    {
        Debug.Log("Début de la Manche " + currentRound);

        currentZombiesKilled = 0;

        isRoundActive = true;
    }

    public void ZombieKilled()
    {
        if (isRoundActive)
        {
            currentZombiesKilled++;
            Debug.Log("Zombie tué ! Total pour cette manche : " + currentZombiesKilled);
        }
    }
}