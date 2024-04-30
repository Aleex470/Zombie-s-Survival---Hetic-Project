using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isGamePaused = false;

    public void TogglePause()
    {
        isGamePaused = !isGamePaused;

        // Mettre en pause ou reprendre le jeu en fonction de l'état de la pause
        Time.timeScale = isGamePaused ? 0f : 1f;

        // Afficher un message dans la console pour indiquer l'état de la pause
        Debug.Log(isGamePaused ? "Jeu en pause" : "Jeu repris");
    }
}
