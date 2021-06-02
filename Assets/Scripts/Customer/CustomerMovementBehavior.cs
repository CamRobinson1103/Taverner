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

//[SerializeField] [Range(0f, 4f)] float lerpTime;
//[SerializeField] Vector3[] myPos;

//int posIndex = 0;
//int length;

//float t = 0f;

//private void Start()
//{
//    length = myPos.Length;
//}

//private void Update()
//{
//    transform.position = Vector3.Lerp(transform.position, myPos[posIndex], lerpTime * Time.deltaTime);

//    t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);

//    if (t > 0.9f)
//    {
//        t = 0f;
//        posIndex++;
//        posIndex = (posIndex >= length) ? 0 : posIndex;
//    }
//}
