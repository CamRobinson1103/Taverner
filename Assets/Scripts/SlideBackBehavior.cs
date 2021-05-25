using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private float SlideBack = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
        {
            transform.forward -= new Vector3(0, 0, SlideBack);
        }
    }
}
