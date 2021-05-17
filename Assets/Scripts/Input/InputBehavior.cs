using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehavior : MonoBehaviour
{
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
