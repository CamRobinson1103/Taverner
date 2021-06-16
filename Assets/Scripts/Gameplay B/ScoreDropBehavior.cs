using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDropBehavior : MonoBehaviour
{
    //Reference to the object that will be dropped
    public GameObject boost;
    //The highest random number
    public int maxNumber;
    //The lowest random number
    public int leastNumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Generates a random number from the range of passed in numbers
        int rand = Random.Range(leastNumber, maxNumber);

        //Checks if the collider is a projectile ("Mug"
        if (other.CompareTag("Mug"))
        {
            //Checks if the random number is 2
            if (rand == 2)
                //If so, spawns a boost object
                Instantiate(boost.gameObject, gameObject.transform.position, gameObject.transform.rotation);

            //Destroys the projectile
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
