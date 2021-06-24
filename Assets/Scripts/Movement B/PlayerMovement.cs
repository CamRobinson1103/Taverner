using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Array of transform points
    public Transform[] TeleportPoints = new Transform[4];
    public Transform[] SkipOver = new Transform[1];
    public Transform[] SkipOver2 = new Transform[1];

    //Reference the character controls
    public CharacterController inputActions;

    //Reference to the Iterator
    int i = 0;

    //Starts up with input actions
    void Start()
    {
        inputActions = GetComponent<CharacterController>();
    }

    public void Movement(int direction)
    {
        //Iterator is set to be direction
        i += direction;
        //Iterator will be clamp
        i = Mathf.Clamp(i, 0, 3);
        //Sets the position of the player to transform points
        inputActions.transform.position = TeleportPoints[i].transform.position;
        inputActions.transform.forward = TeleportPoints[i].transform.forward;
    }

    public void MovementSkipping(int direction)
    {
        //Iterator is set to be direction
        i += direction;

        //If direction is greater
        if (direction > 0)
        {
            //Iterator will be clamp
            i = Mathf.Clamp(i, 0, 0);
            //Sets the position of the player to transform points
            inputActions.transform.position = SkipOver[i].transform.position;
            inputActions.transform.forward = SkipOver[i].transform.forward;
        }
        //If direction is lower
        if (direction < 0)
        {
            //Iterator will be clamp
            i = Mathf.Clamp(i, 0, 0);
            //Sets the position of the player to transform points
            inputActions.transform.position = SkipOver2[i].transform.position;
            inputActions.transform.forward = SkipOver2[i].transform.forward;
        }

    }


}
