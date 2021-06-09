using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDropBehavior : MonoBehaviour
{
    public GameObject boost;
    public int maxNumber;
    public int leastNumber;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        int rand = Random.Range(leastNumber, maxNumber);

        if (collision.gameObject.CompareTag("Mug"))
        {
            if (rand == 2)
                Instantiate(boost.gameObject, gameObject.transform.position, gameObject.transform.rotation);

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
