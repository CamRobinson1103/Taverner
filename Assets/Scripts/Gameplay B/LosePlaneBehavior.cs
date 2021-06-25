using System.Collections;
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
        //Checks if an enemy enters the LosePlane
        if (other.CompareTag("Enemy"))
        {
            //If so removes a life from the life counter
            hud.RemoveLife(1);
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
