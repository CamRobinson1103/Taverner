using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Array used to store the points the player can move to
    public Transform[] MovePoints = new Transform[4];
    //Reference to the player's character controller
    public CharacterController characterController;
    //Iterator for the MovePoints array
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(int direction)
    {
        i += direction;
        i = Mathf.Clamp(i, 0, MovePoints.Length - 1);
        characterController.transform.position = MovePoints[i].transform.position;
        characterController.transform.forward = MovePoints[i].transform.forward;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
