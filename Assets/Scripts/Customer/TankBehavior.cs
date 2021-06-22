using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBehavior : MonoBehaviour
{
    public float HSpeed = 2;
    public int hitsBeforeGone;
    [SerializeField]
    private Vector3 newPosition;
    public float move = 2;
    private bool isLerp = false;
    void Update()
    {
        Move();

        if(hitsBeforeGone <= 0)
        {
            isLerp = true;
        }

        if (isLerp)
        {
            PositionChange();
        }
    }

    void Move()
    {
        transform.position -= new Vector3(0, 0, HSpeed) * Time.deltaTime;
    }

    void PositionChange()
    {
        transform.position = Vector3.Lerp(transform.position, newPosition, move * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            hitsBeforeGone--;
        }
    }
}
