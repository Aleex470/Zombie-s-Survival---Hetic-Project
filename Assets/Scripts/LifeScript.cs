using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScript : MonoBehaviour
{
    public int CurrentLife;
    // Start is called before the first frame update
    public void UpdateLife(int amount)
    {
        CurrentLife -= amount;
        if (CurrentLife < 0 )
        {
            Destroy(this.gameObject);
            ScoreScript.instance.UpdateScore(1);
        }
    }
}
