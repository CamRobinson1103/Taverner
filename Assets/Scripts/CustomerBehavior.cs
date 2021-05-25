using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehavior : MonoBehaviour
{
    bool isDrinking = false;
<<<<<<< HEAD:Assets/Scripts/Customer/CustomerBehavior.cs
=======

    void Update()
    {
        
    }

>>>>>>> Cam'sBranch:Assets/Scripts/CustomerBehavior.cs
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag ("Mug"))
        {
          col.gameObject.GetComponent<SlideBackBehavior>();
            isDrinking = true;
        }

<<<<<<< HEAD:Assets/Scripts/Customer/CustomerBehavior.cs
        if (col.gameObject.tag == "Despawner")
        {
            Destroy(gameObject);
=======
        if (col.gameObject.CompareTag ("Despawner"))
        {
            Destroy(col.gameObject);
>>>>>>> Cam'sBranch:Assets/Scripts/CustomerBehavior.cs
        }

        if (isDrinking == true);
        {

        }
        //col.gameObject.tag == "Mug"
    }
}
