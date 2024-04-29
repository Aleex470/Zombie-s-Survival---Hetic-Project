using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Reset()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("Game");
    }
}
