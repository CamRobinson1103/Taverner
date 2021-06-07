using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    //Reference to the projectile's rigidbody
    public Rigidbody rigidbody;
    //
    private Vector3 _velocity;
    [SerializeField]
    private GameManagerBehavior score;

    public Vector3 Velocity
    {
        get
        {
            return _velocity;
        }
        set
        {
            _velocity = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillPlane"))
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            score.AddScore(5);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.MovePosition(transform.position + _velocity * Time.deltaTime);
    }
}
