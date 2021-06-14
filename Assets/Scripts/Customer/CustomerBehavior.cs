using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            col.gameObject.GetComponent<SlideBackBehavior>();
            timerIsRunning = true;
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }

    }
}