using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehavior : MonoBehaviour
{
    //Reference for the shooting, Serve behavior.
    private ServeBehavior _serve;
<<<<<<< HEAD
<<<<<<< HEAD
=======
    //Reference for the movement, Player movement.
    //private PlayerMovementBehavior _movement;
>>>>>>> Cam'sBranch
=======
    //Reference for the movement, Player movement.
    //private PlayerMovementBehavior _movement;
>>>>>>> parent of 707f5e5... Recreated Set
    //Reference for the player controls.
    private PlayerControls _playerControls;

    private void Awake()
    {
        _playerControls = new PlayerControls();
    }

    // Start is called before the first frame update
    void Start()
    {
        _serve = GetComponent<ServeBehavior>();
        _playerControls.Player.Shoot.performed += context => _serve.Shoot();
<<<<<<< HEAD
<<<<<<< HEAD
=======
        //_movement = GetComponent<PlayerMovementBehavior>();
        //_playerControls.Player.Movement.performed += context => _movement.Move((int)context.ReadValue<float>());
>>>>>>> Cam'sBranch
=======
        //_movement = GetComponent<PlayerMovementBehavior>();
        //_playerControls.Player.Movement.performed += context => _movement.Move((int)context.ReadValue<float>());
>>>>>>> parent of 707f5e5... Recreated Set
    }

    public void OnEnable()
    {
        _playerControls.Enable();
    }

    public void OnDisable()
    {
        _playerControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
