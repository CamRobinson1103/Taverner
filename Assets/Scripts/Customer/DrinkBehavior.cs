using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkBehavior : MonoBehaviour
{
    [SerializeField]
    Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Mug"))
        {
            _animator.SetBool("Drinking", true);
        }
    }
}
