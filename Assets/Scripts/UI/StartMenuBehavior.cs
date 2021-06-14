using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuBehavior : MonoBehaviour
{
    public GameObject gamePause;


    public void GamePlays()
    {

        gamePause.SetActive(false);
        Time.timeScale = 1f;

    }

    public void Start()
    {
        gamePause.SetActive(true);
        Time.timeScale = 0f;

    }
}
