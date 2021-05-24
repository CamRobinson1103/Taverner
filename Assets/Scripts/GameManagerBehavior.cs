using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    public int scoreCounter;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = 0;
    }

    public void AddScore(int multiplier)
    {
        scoreCounter += multiplier;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreCounter;
    }
}
