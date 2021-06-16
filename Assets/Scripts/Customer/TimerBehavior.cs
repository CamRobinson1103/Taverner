using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBehavior : MonoBehaviour
{
    public float HSpeed = 2;
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
                timerIsRunning = false;
                transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;

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
