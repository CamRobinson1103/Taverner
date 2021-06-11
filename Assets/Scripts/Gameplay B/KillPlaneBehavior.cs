﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneBehavior : MonoBehaviour
{
    //Reference to the game manager
    public GameManagerBehavior hud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mug"))
        {
            hud.RemoveLife(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
