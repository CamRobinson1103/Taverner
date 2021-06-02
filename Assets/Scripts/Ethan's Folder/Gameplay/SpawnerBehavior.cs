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

    private void Start()
    {
        StartCoroutine(Spawn());
    }


    private IEnumerator Spawn()
    {
        for (int count = _spawnCount; count > 0; --count)
        {
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            yield return new WaitForSeconds(_nextspawnTime);
        }
    }



}
