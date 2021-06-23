using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectSpawn;
    [SerializeField]
    private float _nextspawnTime;
    private bool _canSpawn;

    //Starts up the Spawn
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        //If its able to spawn
        while(_canSpawn)
        {
            //Instantiates the object and its position
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            //Returns the next spawn time
            yield return new WaitForSeconds(_nextspawnTime);
        }
    }
}
