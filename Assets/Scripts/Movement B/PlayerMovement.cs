using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform[] TeleportPoints = new Transform[4];
    public Transform[] SkipOver = new Transform[1];
    public Transform[] SkipOver2 = new Transform[1];
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
    }

    public void MovementSkipping(int direction)
    {

        i += direction;

        if (direction > 0)
        {
            i = Mathf.Clamp(i, 0, 0);
            inputActions.transform.position = SkipOver[i].transform.position;
        }
        if (direction < 0)
        {
            i = Mathf.Clamp(i, 0, 0);
            inputActions.transform.position = SkipOver2[i].transform.position;
        }

    }


}
