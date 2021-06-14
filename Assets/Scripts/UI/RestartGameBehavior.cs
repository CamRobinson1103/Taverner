using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameBehavior : MonoBehaviour
{
    //Reloads the game
    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
