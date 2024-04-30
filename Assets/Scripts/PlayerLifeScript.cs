using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLifeScript : MonoBehaviour
{
    public int CurrentLife;
    public int MaxLife;
    //public GameObject DeathMenu;

    public GameObject LifeBar;

    private void Start()
    {
        MaxLife = CurrentLife;
    }

    // Start is called before the first frame update
    public void UpdateLife(int amount)
    {
        CurrentLife -= amount;
        if (CurrentLife < 0)
        {
            CurrentLife = 0;
        }
        LifeBar.transform.localScale = new Vector3( (float)CurrentLife / (float)MaxLife , 1, 1);

        //if (CurrentLife < 0)
        //{
        //    Time.timeScale = 0;
        //    DeathMenu.SetActive(true);


        //}
    }
}
