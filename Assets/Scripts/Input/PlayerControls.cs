// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0d28a8eb-62a7-40d9-9b9e-10c9fbab5fd4"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ab989d65-cd4e-4ef7-8c25-df2b4f38bd86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
<<<<<<< HEAD
=======
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""aabb130f-db54-49bc-8c44-e83d836d80d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
>>>>>>> Cam'sBranch
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c464910e-aa58-4554-8f98-92aaf79273b3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c759ab3-2cfa-4345-a92c-013d0e50d765"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
<<<<<<< HEAD
=======
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fdd86b6f-f2d3-4098-b532-cdfa4f5bd880"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""320b518b-d359-4d27-b9d4-f267b80fb5b7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4f976603-121a-41ab-aa33-99ff8a1debdb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
>>>>>>> Cam'sBranch
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
<<<<<<< HEAD
=======
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
>>>>>>> Cam'sBranch
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Shoot;
<<<<<<< HEAD
=======
    private readonly InputAction m_Player_Movement;
>>>>>>> Cam'sBranch
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
<<<<<<< HEAD
=======
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
>>>>>>> Cam'sBranch
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
<<<<<<< HEAD
=======
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
>>>>>>> Cam'sBranch
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
<<<<<<< HEAD
=======
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
>>>>>>> Cam'sBranch
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnShoot(InputAction.CallbackContext context);
<<<<<<< HEAD
=======
        void OnMovement(InputAction.CallbackContext context);
>>>>>>> Cam'sBranch
    }
}
