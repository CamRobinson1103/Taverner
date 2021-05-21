using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed;
    public Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
    }
}
