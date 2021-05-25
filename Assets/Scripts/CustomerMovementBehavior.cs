using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehavior : MonoBehaviour
{
    public float HSpeed = 2;
    public float StartCos = 0;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;
        StartCos += Time.deltaTime;
    }
       
}
