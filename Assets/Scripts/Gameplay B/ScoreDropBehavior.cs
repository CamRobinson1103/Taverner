using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDropBehavior : MonoBehaviour
{
    public GameObject boost;
    public float maxNumber;
    public float leastNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDestroy()
    {
        float randNum = Random.Range(leastNumber, maxNumber);

        if (randNum.Equals(0))
        {
            Instantiate(boost.gameObject, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
