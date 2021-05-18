using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomerBehavior : MonoBehaviour
{
    [Tooltip("The rigidbody attached to this object.")]
    [SerializeField]
    private Rigidbody _rigidbody;
    [Tooltip("The object the enemy will be seeking towards.")]
    [SerializeField]
    private GameObject _target;
    private NavMeshAgent _agent;

    public GameObject Target
    {
        get
        {
            return _target;
        }
        set
        {
            _target = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Get a reference to the attached rigidbody
        _rigidbody = GetComponent<Rigidbody>();
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //If a target hasn't been set return
        if (!_target)
            return;

        _agent.SetDestination(_target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mug")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(3000, 0, 0);
        }

        if (collision.gameObject.tag == "Customer")
        {
            Debug.Log("If you see this, you're ugly");
        }
    }



}
