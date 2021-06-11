using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    private Vector3 newPosition;
    public float move = 2;
    private bool isLerp = false;
    //Taemin goin stupid in the stu again.. wait til this man leanes the military. He finna go DUMB STOOOOPID in the stu

    private void Update()
    {
        if (isLerp)
        {
            PositionChange();
        }
    }
    void PositionChange()
    {
        Vector3 positionA = new Vector3(0,0,0);
        newPosition = positionA;

        transform.position = Vector3.Lerp(transform.position, newPosition, move * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Mug"))
        {
            isLerp = true;
        }
    }
}

