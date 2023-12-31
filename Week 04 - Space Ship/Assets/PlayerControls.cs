//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""14573f51-4baf-4411-8369-e7f663b86547"",
            ""actions"": [
                {
                    ""name"": ""Movement1"",
                    ""type"": ""Value"",
                    ""id"": ""47f5ff2d-1d87-4ae5-97fa-3698444e04d1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting1"",
                    ""type"": ""Button"",
                    ""id"": ""193c6a5f-6db0-49a7-9ee0-fff605d83bbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement2"",
                    ""type"": ""Value"",
                    ""id"": ""50096601-bb0f-471f-a09a-d47cbb27c542"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting2"",
                    ""type"": ""Value"",
                    ""id"": ""895fe42b-1650-4493-82de-893221113699"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1b3fd4e-8c10-44ca-a631-918ece7d5844"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17aa9cd6-bd8f-4935-9b26-38baaa78caa9"",
                    ""path"": ""<DualShockGamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94a8a642-cc48-450c-bc44-c7c910b4dc66"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccf378ba-2d0b-4300-9aac-9267ddafdac4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba1032dd-8b54-4753-b570-d66d0dcd4a6d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b03a03b-11bc-4d49-ba0f-3f5405d1d32a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae2dad2a-e78c-4446-aa07-fed793ba89ba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c40ac0f8-ec8a-4814-91d3-d00286b025a9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Movement1 = m_GamePlay.FindAction("Movement1", throwIfNotFound: true);
        m_GamePlay_Shooting1 = m_GamePlay.FindAction("Shooting1", throwIfNotFound: true);
        m_GamePlay_Movement2 = m_GamePlay.FindAction("Movement2", throwIfNotFound: true);
        m_GamePlay_Shooting2 = m_GamePlay.FindAction("Shooting2", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private List<IGamePlayActions> m_GamePlayActionsCallbackInterfaces = new List<IGamePlayActions>();
    private readonly InputAction m_GamePlay_Movement1;
    private readonly InputAction m_GamePlay_Shooting1;
    private readonly InputAction m_GamePlay_Movement2;
    private readonly InputAction m_GamePlay_Shooting2;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement1 => m_Wrapper.m_GamePlay_Movement1;
        public InputAction @Shooting1 => m_Wrapper.m_GamePlay_Shooting1;
        public InputAction @Movement2 => m_Wrapper.m_GamePlay_Movement2;
        public InputAction @Shooting2 => m_Wrapper.m_GamePlay_Shooting2;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void AddCallbacks(IGamePlayActions instance)
        {
            if (instance == null || m_Wrapper.m_GamePlayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Add(instance);
            @Movement1.started += instance.OnMovement1;
            @Movement1.performed += instance.OnMovement1;
            @Movement1.canceled += instance.OnMovement1;
            @Shooting1.started += instance.OnShooting1;
            @Shooting1.performed += instance.OnShooting1;
            @Shooting1.canceled += instance.OnShooting1;
            @Movement2.started += instance.OnMovement2;
            @Movement2.performed += instance.OnMovement2;
            @Movement2.canceled += instance.OnMovement2;
            @Shooting2.started += instance.OnShooting2;
            @Shooting2.performed += instance.OnShooting2;
            @Shooting2.canceled += instance.OnShooting2;
        }

        private void UnregisterCallbacks(IGamePlayActions instance)
        {
            @Movement1.started -= instance.OnMovement1;
            @Movement1.performed -= instance.OnMovement1;
            @Movement1.canceled -= instance.OnMovement1;
            @Shooting1.started -= instance.OnShooting1;
            @Shooting1.performed -= instance.OnShooting1;
            @Shooting1.canceled -= instance.OnShooting1;
            @Movement2.started -= instance.OnMovement2;
            @Movement2.performed -= instance.OnMovement2;
            @Movement2.canceled -= instance.OnMovement2;
            @Shooting2.started -= instance.OnShooting2;
            @Shooting2.performed -= instance.OnShooting2;
            @Shooting2.canceled -= instance.OnShooting2;
        }

        public void RemoveCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamePlayActions instance)
        {
            foreach (var item in m_Wrapper.m_GamePlayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamePlayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnMovement1(InputAction.CallbackContext context);
        void OnShooting1(InputAction.CallbackContext context);
        void OnMovement2(InputAction.CallbackContext context);
        void OnShooting2(InputAction.CallbackContext context);
    }
}
