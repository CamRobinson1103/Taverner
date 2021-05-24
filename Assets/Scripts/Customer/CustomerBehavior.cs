using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    float timeLeft = 30.0f;
    bool timerCheck = false;
    bool isDrinking = false;

    void Update()
    {
        timeLeft -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mug")
        {
          col.gameObject.GetComponent<SlideBackBehavior>();
            isDrinking = true;
        }

        if (isDrinking == true) 
        {
            timerCheck = true;
        }

        if (col.gameObject.tag == "Despawner")
        {
            Destroy(gameObject);
        }
            
    }
}
