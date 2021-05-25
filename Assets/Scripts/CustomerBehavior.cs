using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    bool isDrinking = false;


    void Update()
    {

    }


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            col.gameObject.GetComponent<SlideBackBehavior>();
            isDrinking = true;
        }


        if (col.gameObject.tag == "Despawner")
        {
            Destroy(gameObject);

            if (col.gameObject.CompareTag("Despawner"))
            {
                Destroy(col.gameObject);

            }

            if (isDrinking == true) ;
            {

            }
            //col.gameObject.tag == "Mug"
        }
    }
}

