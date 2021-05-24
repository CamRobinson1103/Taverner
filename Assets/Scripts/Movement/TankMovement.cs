using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float TankSlideBack = 5;
    public float TankMovingSpeed = 3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Drink"))
            Destroy(other.gameObject);
            transform.position -= new Vector3(0, 0, -TankSlideBack) * Time.deltaTime;
    }

    public void Update()
    {
        transform.position -= new Vector3(0, 0, TankMovingSpeed) * Time.deltaTime;
    }
}
