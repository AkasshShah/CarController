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
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""38fe0b8e-c63d-49bf-9630-95f242aa806d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b9b396a-785d-4034-b9c4-c230b3a62fa9"",
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
                    ""id"": ""b9f7492d-40eb-48bf-a5e0-09fab75731e9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""193c9c25-3973-49ef-961f-e011e245a34a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""546c6ec8-ac33-4bd3-b758-6044ef8ae3e5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Direction"",
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
        m_GamepadController_Accelerate = m_GamepadController.FindAction("Accelerate", throwIfNotFound: true);
        m_GamepadController_Brake = m_GamepadController.FindAction("Brake", throwIfNotFound: true);
        m_GamepadController_Direction = m_GamepadController.FindAction("Direction", throwIfNotFound: true);
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
    private readonly InputAction m_GamepadController_Accelerate;
    private readonly InputAction m_GamepadController_Brake;
    private readonly InputAction m_GamepadController_Direction;
    public struct GamepadControllerActions
    {
        private @CarControls m_Wrapper;
        public GamepadControllerActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Headlight => m_Wrapper.m_GamepadController_Headlight;
        public InputAction @Accelerate => m_Wrapper.m_GamepadController_Accelerate;
        public InputAction @Brake => m_Wrapper.m_GamepadController_Brake;
        public InputAction @Direction => m_Wrapper.m_GamepadController_Direction;
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
                @Accelerate.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnAccelerate;
                @Brake.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnBrake;
                @Direction.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
                @Direction.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
                @Direction.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDirection;
            }
            m_Wrapper.m_GamepadControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Headlight.started += instance.OnHeadlight;
                @Headlight.performed += instance.OnHeadlight;
                @Headlight.canceled += instance.OnHeadlight;
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Direction.started += instance.OnDirection;
                @Direction.performed += instance.OnDirection;
                @Direction.canceled += instance.OnDirection;
            }
        }
    }
    public GamepadControllerActions @GamepadController => new GamepadControllerActions(this);
    public interface IGamepadControllerActions
    {
        void OnHeadlight(InputAction.CallbackContext context);
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
    }
}
