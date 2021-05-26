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
            Debug.Log("It works");
        }

        if (col.gameObject.CompareTag("Despawner"))
        {
            Destroy(gameObject);
        }
    }
}