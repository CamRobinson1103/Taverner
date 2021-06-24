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
    public void ActivateDrinkTrigger()
    {
        _animator.SetTrigger("Win");
    }
}
