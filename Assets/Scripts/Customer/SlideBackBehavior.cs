using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    public float SlideBack = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            transform.position -= new Vector3(0, 0, SlideBack) * Time.deltaTime;
        }
    }
}
