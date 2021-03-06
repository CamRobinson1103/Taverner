using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServeBehavior : MonoBehaviour
{
    //Reference to the object that will be serving
    public GameObject server;
    //Instance of ProjectileBehavior used for the drinks that will be served
    public ProjectileBehavior drink;
    //Reference to the drink's game object
    GameObject _drink;
    //Variable used to decide the time between each bullet
    public float timeBetweenShots;
    //Variable used to store the time plus the timeBetween shots
    private float nextShot;
    //The server's firerate
    [SerializeField]
    private float shootSpeed;
    [SerializeField]
    private GameManagerBehavior _score;
    [SerializeField]
    private PlayerAnimationBehavior _playerAnimation;

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimationBehavior>();
    }

    public void Shoot()
    {
        if (Time.time > nextShot)
        {
            nextShot = Time.time + timeBetweenShots;
            //Sets _drink to instantiate the drink's gameobject at the server's position
            _drink = Instantiate(drink.gameObject, server.transform.position, server.transform.rotation);
            //Calls GetComponent for the _drink with a new ProjectileBehavior
            ProjectileBehavior moveDrink = _drink.GetComponent<ProjectileBehavior>();
            //Sets the velocity to the server's forward scaled by the firerate
            moveDrink.Velocity = transform.forward * shootSpeed;
            //
            _playerAnimation.Shoot();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        //Checks if the collider is a ScoreBoost
        if (other.CompareTag("ScoreBoost"))
        {
            //Adds points to the scoreboard
            _score.AddScore(5);
            //Destroys the scoreboost
            Destroy(other.gameObject);
        }
        //Checks if the collider is a ScoreBoost-B
        else if(other.CompareTag("ScoreBoost-B"))
        {
            //Adds points to the scoreboard
            _score.AddScore(10);
            //Destroys the scoreboost
            Destroy(other.gameObject);
        }
    }
}
