using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempObjectMovementBehavior : MonoBehaviour
{
    private Rigidbody _object;
    private float _objectspeed;

    // Start is called before the first frame update
    void Start()
    {
        _object = GetComponent<Rigidbody>();
        _objectspeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _object.velocity = transform.right * _objectspeed;
    }
}
