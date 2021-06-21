using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectSpawn;
    [SerializeField]
    private float _nextspawnTime;
    [SerializeField]
    private int _spawnCount;
    //private int waveIndex = 0;
    //private SpawnerBehavior[] waveArrays;


    //Starts up the Spawn
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    //For everytime object spawns it decreases the spawn count
    private IEnumerator Spawn()
    {
        //SpawnerBehavior wave = waveArrays[waveIndex];

        for (int count = _spawnCount; count > 0; --count)
        {
            //Instantiates the object and its position
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            //Returns the next spawn time
            yield return new WaitForSeconds(_nextspawnTime);
        }
        //waveIndex++;


        //if (waveIndex == waveArrays.Length)
        //{
        //    this.enabled = false;
        //}
    }
}
