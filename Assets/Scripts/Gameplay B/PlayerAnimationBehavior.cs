using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationBehavior : MonoBehaviour
{
    //Reference to the animator
    public Animator animator;
    //Reference to ServeBehavior
    public ServeBehavior serve;

    // Start is called before the first frame update
    void Start()
    {
        serve = GetComponent<ServeBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetTrigger("Throw");
    }
}
