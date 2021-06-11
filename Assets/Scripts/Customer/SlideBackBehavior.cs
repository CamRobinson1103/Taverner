using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideBackBehavior : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private Vector3 newPosition;
    public float move = 2;
    private bool isLerp = false;

    private void Update()
    {
        if (isLerp)
        {
            PositionChange();
        }
    }
    void PositionChange()
    {
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

