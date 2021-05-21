﻿using System.Collections;
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
    //
    public float timeBetweenShots;
    //
    private float nextShot;
    //
    public GameManagerBehavior score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot(Vector3 force)
    {
        if (Time.time > nextShot)
        {
            nextShot = Time.time + timeBetweenShots;
            //Sets _drink to instantiate the drink's gameobject at the server's position
            _drink = Instantiate(drink.gameObject, server.transform.position, server.transform.rotation);
            //Calls GetComponent for the _drink with a new ProjectileBehavior
            ProjectileBehavior moveDrink = _drink.GetComponent<ProjectileBehavior>();
            //Moves the projectile in a direction
            moveDrink.rigidbody.AddForce(force, ForceMode.Impulse);
            score.AddScore(10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
