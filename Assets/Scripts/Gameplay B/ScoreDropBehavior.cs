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

    private void OnTriggerEnter(Collider other)
    {
        int rand = Random.Range(leastNumber, maxNumber);

        if (other.CompareTag("Mug"))
        {
            if (rand == 2)
                Instantiate(boost.gameObject, gameObject.transform.position, gameObject.transform.rotation);

            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
