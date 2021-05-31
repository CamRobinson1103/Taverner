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
    private float _nextspawnTime;
    [SerializeField]
    private float _nextspawnTime2;
    [SerializeField]
    private int _spawnCount;
    [SerializeField]
    private int _spawnCount2;



    private void Start()
    {
        StartCoroutine(Spawn());
    }


    public IEnumerator Spawn()
    {
        for (int count = _spawnCount; count > 0; --count)
        {
            GameObject gameobject = Instantiate(_objectSpawn, transform.position, new Quaternion());
            yield return new WaitForSeconds(_nextspawnTime);
        }

        for (int count = _spawnCount2; count > 0; --count)
        {
            GameObject gameobject2 = Instantiate(_objectSpawn2, transform.position, new Quaternion());
            yield return new WaitForSeconds(_nextspawnTime2);
        }
    }




}
