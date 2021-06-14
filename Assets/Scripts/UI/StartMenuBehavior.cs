using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuBehavior : MonoBehaviour
{
    public GameObject gamePause;

    //Game will unpause and play
    public void GamePlays()
    {
        gamePause.SetActive(false);
        Time.timeScale = 1f;
    }

    //Game is pause in the background
    public void Start()
    {
        gamePause.SetActive(true);
        Time.timeScale = 0f;
    }
}
