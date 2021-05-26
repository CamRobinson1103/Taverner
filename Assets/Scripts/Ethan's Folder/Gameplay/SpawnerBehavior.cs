using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    public GameObject _objectSpawn;
    [SerializeField]
    private bool _canspawntime;
    [SerializeField]
    private float _nextspawnTime = 5;

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
    }
}
