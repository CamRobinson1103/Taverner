using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            col.gameObject.GetComponent<SlideBackBehavior>();
        }

        if (col.gameObject.CompareTag("KillPlane"))
        {
            Debug.Log("It works yay");
        }

        if(col.gameObject.CompareTag("LoseBox"))
        {
            Debug.Log("You Lose!");
        }
    }
}