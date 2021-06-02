using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private float SlideBack = 5;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Mug"))
        {
            transform.forward -= new Vector3(0, -SlideBack, 0);
        }
    }
}