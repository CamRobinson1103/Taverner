using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehavior : MonoBehaviour
{
    //Reference for the shooting, Serve behavior.
    private ServeBehavior _serve;
    //Reference for the movement, Player movement.
    private PlayerMovement _movement;
    //Reference Player's skip movement
    private PlayerMovement _skipMovement;
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
        _movement = GetComponent<PlayerMovement>();
        _playerControls.Player.Movement.performed += context => _movement.Movement((int)context.ReadValue<float>());
        _skipMovement = GetComponent<PlayerMovement>();
        _playerControls.Player.SkipMovement.performed += context => _skipMovement.MovementSkipping((int)context.ReadValue<float>());
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
