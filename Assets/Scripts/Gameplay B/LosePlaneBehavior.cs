﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePlaneBehavior : MonoBehaviour
{
    //Reference to the game manager
    public GameManagerBehavior hud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            hud.RemoveLife(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
