using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private int _score;

    public static ScoreScript instance;
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(instance);
    }

    public void UpdateScore(int points)
    {
        _score += points;
        GetComponent<TextMeshProUGUI>().text = "Score : " + _score;
    }
}
