using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    public GameObject _objectSpawn;
    [SerializeField]
    public GameObject _objectSpawn2;
    [SerializeField]
    private bool _canspawntime;
    [SerializeField]
    private float _nextspawnTime = 5;
    [SerializeField]
    private float _randomTime;


    private void Start()
    {
        StartCoroutine(Spawn());
    }


    public IEnumerator Spawn()
    {
        while (_canspawntime)
        {
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            yield return new WaitForSeconds(_nextspawnTime);
        }

        while (_canspawntime)
        {
            GameObject gameobject = Instantiate(_objectSpawn2, transform.position, new Quaternion());
            yield return new WaitForSeconds(_randomTime);
        }
    }


    public void RandomTime()
    {
        _randomTime = Random.Range(1, 5);
    }

}
