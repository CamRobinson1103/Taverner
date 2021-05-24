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
            transform.position -= new Vector3(-SlideBack, 0, 0) * Time.deltaTime;
        }
    }
    
}

