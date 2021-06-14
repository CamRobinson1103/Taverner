using System.Collections;
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
                Debug.Log("Timer works");
                timeRemaining = 0;
                gameObject.GetComponent<CustomerMovementBehavior>();
                timerIsRunning = false;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            timerIsRunning = true;
        }
    }
}
