using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehavior : MonoBehaviour
{
    private PlayerMovement _move;
    private PlayerMovement _skip;
    //Reference for the shooting, Serve behavior.
    private ServeBehavior _serve;
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
        _move = GetComponent<PlayerMovement>();
        _playerControls.Player.Movement.performed += context => _move.Movement((int)context.ReadValue<float>());
        _skip = GetComponent<PlayerMovement>();
        _playerControls.Player.SkipMovement.performed += context => _skip.MovementSkipping((int)context.ReadValue<float>());
    }

    public void OnEnable()
    {
        _playerControls.Enable();
    }

    public void OnDisable()
    {
        _playerControls.Disable();
    }


}
