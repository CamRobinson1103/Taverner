using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBehavior : MonoBehaviour
{
    public float timeRemaining = 3;
    public bool timerIsRunning = false;
    public float HSpeed = 2;

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
                timeRemaining = 0;
                timerIsRunning = false;
            }
            if (timeRemaining == 0)
            {
                Debug.Log("Timer works");
            }

        }
     
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            timerIsRunning = true;
        }

        if (timeRemaining == 0)
        {
            transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;
        }
    }
}
