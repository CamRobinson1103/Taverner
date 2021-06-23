using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    //Reference to the projectile's rigidbody
    public Rigidbody rigidbody;
    //The projectiles velocity
    private Vector3 _velocity;
    [SerializeField]
    //Reference to the scoreboard
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
        //Calls GetComponent for the projectile's rigidbody
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Checks if the collider is the KillPlane
        if (other.CompareTag("KillPlane"))
            //Destroys the projectile
            Destroy(gameObject);

        //Checks if the collider is a customer(enemy)
        else if (other.CompareTag("ServePoint"))
        {
            //Adds to the scoreboard
            score.AddScore(5);
            Destroy(gameObject);
        }

        //Checks if the collider is a ScoreBoost
        else if (other.CompareTag("ScoreBoost"))
        {
            //Adds points to the scoreboard
            score.AddScore(5);
            //Destroys the scoreboost
            Destroy(other.gameObject);
            //Destroys the projectile
            Destroy(gameObject);
        }

        //Checks if the collider is a ScoreBoost-B
        else if (other.CompareTag("ScoreBoost-B"))
        {
            //Adds points to the scoreboard
            score.AddScore(10);
            //Destroys the scoreboost
            Destroy(other.gameObject);
            //Destroys the projectile
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moves the projectile
        rigidbody.MovePosition(transform.position + _velocity * Time.deltaTime);
    }
}
