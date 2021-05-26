using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovementBehavior : MonoBehaviour
{
    public float HSpeed = 2;
    float lerpDuration = 3;
    float startValue = 0;
    float endValue = 10;
    float valueToLerp;

    void Start()
    {
        StartCoroutine(Lerp());
    }

    IEnumerator Lerp()
    {
        float timeElapsed = 0;

        while (timeElapsed < lerpDuration)
        {
            valueToLerp = Mathf.Lerp(startValue, endValue, timeElapsed / lerpDuration);
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        valueToLerp = endValue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;

    }
    
}
