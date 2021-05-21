using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    bool isDrinking = false;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Mug")
        {
          col.gameObject.GetComponent<SlideBackBehavior>();
            isDrinking = true;
        }

        if (col.gameObject.tag == "Despawner")
        {
            Destroy(gameObject);
        }

        if (isDrinking == true);
        {

        }
            
    }
}
