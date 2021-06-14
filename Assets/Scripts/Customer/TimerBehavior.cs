﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBehavior : MonoBehaviour
{
    public float timeRemaining = 3;
    public bool timerIsRunning = false;

    private void Start()
    {

    }

    void Update()
    {
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
                gameObject.GetComponent<CustomerMovementBehavior>();
            }
        }
    }

    //private void OnTriggerEnter(Collider col)
    //{
    //    if (col.gameObject.CompareTag("Mug"))
    //    {
    //        timerIsRunning = true;
    //    }

    //    if (timerIsRunning)
    //    {
    //        if (timeRemaining > 0)
    //        {
    //            timeRemaining -= Time.deltaTime;
    //        }
    //        else
    //        {
    //            Debug.Log("Time has run out!");
    //            timeRemaining = 0;
    //            timerIsRunning = false;
    //            col.gameObject.GetComponent<CustomerMovementBehavior>();
    //        }
    //    }
    //}
}
