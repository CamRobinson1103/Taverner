using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectSpawn;
    [SerializeField]
    private GameObject _objectSpawn2;
    [SerializeField]
    private bool _canspawnTime;
    [SerializeField]
    private float _nextspawnTime = 5.0f;
    //[SerializeField]
    //private float _nextspawnTime2 = 10.0f;



    private void Start()
    {
        StartCoroutine(Spawn());
    }


    public IEnumerator Spawn()
    {
        while (_canspawnTime)
        {
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            yield return new WaitForSeconds(_nextspawnTime = 10.0f);
            yield return StartCoroutine(Spawn2());
        }

    }
    
    public IEnumerator Spawn2()
    {
        GameObject gameobject2 = Instantiate(_objectSpawn2, transform.position, new Quaternion());
        yield return new WaitForSeconds(2.0f);
    }


}
