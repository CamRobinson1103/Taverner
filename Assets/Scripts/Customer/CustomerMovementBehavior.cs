using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehavior : MonoBehaviour
{
    public float HSpeed = 2;

    void Update()
    {
        transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;

    }
}

