using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    private bool isLerp = false;
    private Vector3 newPosition;
    public float move = 2;

    private void Update()
    {
        if (isLerp)
        {
            PositionChange();
        }
    }

    void PositionChange()
    {
        Vector3 positionA = new Vector3(0, 1, 4);
        newPosition = positionA;

        transform.position = Vector3.Lerp(transform.position, newPosition, move * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Mug"))
        {
            isLerp = true;
            //Add timer for customer for after collisiin
            //Instead of going to a specific spot, customer just moves back
        }
    }
}

