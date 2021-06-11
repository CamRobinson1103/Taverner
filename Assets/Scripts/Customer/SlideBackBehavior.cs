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
    //I thought I had something. Japanese sounds so good to me. I'm... nvm I was faded in that last song
    // TALK TO THESE NIGGAS JOHNATHAN
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag ("Mug"))
        {
            isLerp = true;
        }
    }
}

