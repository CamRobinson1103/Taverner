using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    public float SlideBack = 5;

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag =="Mug")
        {
            //transform.forward
            transform.forward -= new Vector3(SlideBack, 0, 0);
        }
    }
}

