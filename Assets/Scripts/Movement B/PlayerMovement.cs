using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform[] TeleportPoints = new Transform[4];
    public Transform[] SkipOver = new Transform[2];
    public CharacterController inputActions;
    int i = 0;

    void Start()
    {
        inputActions = GetComponent<CharacterController>();
    }

    public void Movement(int direction)
    {
        i += direction;
        i = Mathf.Clamp(i, 0, 3);
        inputActions.transform.position = TeleportPoints[i].transform.position;
        inputActions.transform.forward = TeleportPoints[i].transform.forward;
    }

    public void MovementSkipping(int direction)
    {
        i += direction;
        i = Mathf.Clamp(i, 0, 1);
        inputActions.transform.position = SkipOver[i].transform.position;
        //if (gameObject.transform)
        //{
        //    inputActions.transform.position = SkipOver[i].transform.position;
        //}
        
    }

}
