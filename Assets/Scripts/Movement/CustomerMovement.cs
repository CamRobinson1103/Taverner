using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    public float DefaultSlideBack = 5;
    public float DefaultMovingSpeed = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
            Destroy(other.gameObject);

        if (other.gameObject)
            transform.position -= new Vector3(0, 0, -DefaultSlideBack) * Time.deltaTime;
    }

    public void Update()
    {
        transform.position -= new Vector3(0, 0, DefaultMovingSpeed) * Time.deltaTime;
    }
}
