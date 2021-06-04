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

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreBoost"))
        {
            _score.AddScore(5);
            Destroy(other.gameObject);
        }
        else if(other.CompareTag("ScoreBoost-B"))
        {
            _score.AddScore(10);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
