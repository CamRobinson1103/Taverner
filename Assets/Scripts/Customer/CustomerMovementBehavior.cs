using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehavior : MonoBehaviour
{
    public float HSpeed = 2;
    public float timeRemaining = 3;
    public bool timerIsRunning = false;

    void Update()
    {
        Move();

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
            }
        }

        if(timeRemaining == 0)
        {
            Move();
        }
    }

     void Move()
     {
        transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;
     }        

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            timerIsRunning = true;
        }
    }
}

