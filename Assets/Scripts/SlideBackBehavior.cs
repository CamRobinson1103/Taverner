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
            Debug.Log("It works");
            transform.forward -= new Vector3(0, 0, SlideBack) * Time.deltaTime;
        }
    }
}