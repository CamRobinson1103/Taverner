using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEventBehavior : MonoBehaviour
{
    private PlayerMovementBehavior _move;
    private PlayerMovementBehavior _skip;
    private PlayerControls _playerInputs;

    // Start is called before the first frame update
    void Awake()
    {
        _playerInputs = new PlayerControls();
    }

    void Start()
    {
        _move = GetComponent<PlayerMovementBehavior>();
        _playerInputs.Player.Movement.performed += context => _move.Movement((int)context.ReadValue<float>());
        _skip = GetComponent<PlayerMovementBehavior>();
        _playerInputs.Player.SkipMovement.performed += context => _skip.MovementSkipping((int)context.ReadValue<float>());
    }

    public void OnEnable()
    {
        _playerInputs.Enable();
    }

    public void OnDisable()
    {
        _playerInputs.Disable();
    }
}
