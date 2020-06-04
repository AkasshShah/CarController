// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/CarControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CarControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControls"",
    ""maps"": [
        {
            ""name"": ""GamepadController"",
            ""id"": ""737220f2-cfb1-4b59-b8f1-cf446e68f7fb"",
            ""actions"": [
                {
                    ""name"": ""Headlight"",
                    ""type"": ""Button"",
                    ""id"": ""e818e1b0-60a9-40c1-b1fc-d9063a5c8cc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Direction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""273f1587-4b5b-4afb-b479-278cf883250a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e48165c6-22ae-47b3-a4dd-e3141b1db985"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f442366b-73b9-4a66-a9db-4c0720de7ed2"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Headlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""546c6ec8-ac33-4bd3-b758-6044ef8ae3e5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ebbcf48-aa73-4d51-9308-1ed446641a5f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamepadController
        m_GamepadController = asset.FindActionMap("GamepadController", throwIfNotFound: true);
        m_GamepadController_Headlight = m_GamepadController.FindAction("Headlight", throwIfNotFound: true);
        m_GamepadController_Direction = m_GamepadController.FindAction("Direction", throwIfNotFound: true);
        m_GamepadController_Acceleration = m_GamepadController.FindAction("Acceleration", throwIfNotFound: true);
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

    // GamepadController
    private readonly InputActionMap m_GamepadController;
    private IGamepadControllerActions m_GamepadControllerActionsCallbackInterface;
    private readonly InputAction m_GamepadController_Headlight;
    private readonly InputAction m_GamepadController_Direction;
    private readonly InputAction m_GamepadController_Acceleration;
    public struct GamepadControllerActions
    {
        private @CarControls m_Wrapper;
        public GamepadControllerActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Headlight => m_Wrapper.m_GamepadController_Headlight;
        public InputAction @Direction => m_Wrapper.m_GamepadController_Direction;
        public InputAction @Acceleration => m_Wrapper.m_GamepadController_Acceleration;
        public InputActionMap Get() { return m_Wrapper.m_GamepadController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadControllerActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadControllerActions instance)
        {
            if (m_Wrapper.m_GamepadControllerActionsCallbackInterface != null)
            {
                @Headlight.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnHeadlight;
                @Headlight.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnHeadlight;
                @Headlight.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnHeadlight;
                @Direction.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
                @Acceleration.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAcceleration;
            }
            m_Wrapper.m_GamepadControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Headlight.started += instance.OnHeadlight;
                @Headlight.performed += instance.OnHeadlight;
                @Headlight.canceled += instance.OnHeadlight;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
            }
        }
    }
    public GamepadControllerActions @GamepadController => new GamepadControllerActions(this);
    public interface IGamepadControllerActions
    {
        void OnHeadlight(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
    }
}
