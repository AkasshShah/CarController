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
                },
                {
                    ""name"": ""IncreaseThrottleMultiplier"",
                    ""type"": ""Button"",
                    ""id"": ""377cc121-259b-449e-92d7-01cead8ed28a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecreaseThrottleMultiplier"",
                    ""type"": ""Button"",
                    ""id"": ""dc1bc2a3-ef39-4f35-adff-731c5f45509d"",
                    ""expectedControlType"": ""Button"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""4bb55381-a1b7-4396-8344-03d91987f598"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseThrottleMultiplier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0abdacff-a190-4324-aa72-2c4fbe7d2e5e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseThrottleMultiplier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""fd99554b-697f-4a52-bec4-1a51954ed9d5"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""d92ab2f1-3b53-474b-837b-93e051a6f3d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backward"",
                    ""type"": ""Button"",
                    ""id"": ""ac443607-c55e-4544-87cc-69001dfca620"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""a040c046-dc43-4521-9746-e7202a9d00b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""0d973159-6c0e-437f-9759-0ec0c8d30619"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Headlight"",
                    ""type"": ""Button"",
                    ""id"": ""225d4892-54e4-4775-898b-916fd19f5747"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseThrottleMultiplier"",
                    ""type"": ""Button"",
                    ""id"": ""44434aa6-5483-4166-988e-cf5d9b96751e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecreaseThrottleMultiplier"",
                    ""type"": ""Button"",
                    ""id"": ""4a547099-1d61-4f00-b552-8d048ae78f65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9dbe357a-968a-464c-ae84-a6a9ac8262b9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc323b9e-5c17-4192-b427-828b57509a82"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77f71558-8e8b-4433-9cc5-3d11c3f7b733"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b484f815-b278-412b-87f9-bd89af10a9e1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42fe5799-8c7d-4ddb-b957-da2c964ee502"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Headlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f77d7cb-08c6-4448-95ea-beff868a1f35"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncreaseThrottleMultiplier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8368a433-27b1-4175-bd4d-6008c3fcff9a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseThrottleMultiplier"",
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
        m_GamepadController_IncreaseThrottleMultiplier = m_GamepadController.FindAction("IncreaseThrottleMultiplier", throwIfNotFound: true);
        m_GamepadController_DecreaseThrottleMultiplier = m_GamepadController.FindAction("DecreaseThrottleMultiplier", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_Forward = m_Keyboard.FindAction("Forward", throwIfNotFound: true);
        m_Keyboard_Backward = m_Keyboard.FindAction("Backward", throwIfNotFound: true);
        m_Keyboard_Right = m_Keyboard.FindAction("Right", throwIfNotFound: true);
        m_Keyboard_Left = m_Keyboard.FindAction("Left", throwIfNotFound: true);
        m_Keyboard_Headlight = m_Keyboard.FindAction("Headlight", throwIfNotFound: true);
        m_Keyboard_IncreaseThrottleMultiplier = m_Keyboard.FindAction("IncreaseThrottleMultiplier", throwIfNotFound: true);
        m_Keyboard_DecreaseThrottleMultiplier = m_Keyboard.FindAction("DecreaseThrottleMultiplier", throwIfNotFound: true);
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
    private readonly InputAction m_GamepadController_IncreaseThrottleMultiplier;
    private readonly InputAction m_GamepadController_DecreaseThrottleMultiplier;
    public struct GamepadControllerActions
    {
        private @CarControls m_Wrapper;
        public GamepadControllerActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Headlight => m_Wrapper.m_GamepadController_Headlight;
        public InputAction @Direction => m_Wrapper.m_GamepadController_Direction;
        public InputAction @Acceleration => m_Wrapper.m_GamepadController_Acceleration;
        public InputAction @IncreaseThrottleMultiplier => m_Wrapper.m_GamepadController_IncreaseThrottleMultiplier;
        public InputAction @DecreaseThrottleMultiplier => m_Wrapper.m_GamepadController_DecreaseThrottleMultiplier;
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
                @IncreaseThrottleMultiplier.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.started -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.performed -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.canceled -= m_Wrapper.m_GamepadControllerActionsCallbackInterface.OnDecreaseThrottleMultiplier;
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
                @IncreaseThrottleMultiplier.started += instance.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.performed += instance.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.canceled += instance.OnIncreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.started += instance.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.performed += instance.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.canceled += instance.OnDecreaseThrottleMultiplier;
            }
        }
    }
    public GamepadControllerActions @GamepadController => new GamepadControllerActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_Forward;
    private readonly InputAction m_Keyboard_Backward;
    private readonly InputAction m_Keyboard_Right;
    private readonly InputAction m_Keyboard_Left;
    private readonly InputAction m_Keyboard_Headlight;
    private readonly InputAction m_Keyboard_IncreaseThrottleMultiplier;
    private readonly InputAction m_Keyboard_DecreaseThrottleMultiplier;
    public struct KeyboardActions
    {
        private @CarControls m_Wrapper;
        public KeyboardActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_Keyboard_Forward;
        public InputAction @Backward => m_Wrapper.m_Keyboard_Backward;
        public InputAction @Right => m_Wrapper.m_Keyboard_Right;
        public InputAction @Left => m_Wrapper.m_Keyboard_Left;
        public InputAction @Headlight => m_Wrapper.m_Keyboard_Headlight;
        public InputAction @IncreaseThrottleMultiplier => m_Wrapper.m_Keyboard_IncreaseThrottleMultiplier;
        public InputAction @DecreaseThrottleMultiplier => m_Wrapper.m_Keyboard_DecreaseThrottleMultiplier;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnForward;
                @Backward.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBackward;
                @Backward.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBackward;
                @Backward.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnBackward;
                @Right.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Headlight.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnHeadlight;
                @Headlight.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnHeadlight;
                @Headlight.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnHeadlight;
                @IncreaseThrottleMultiplier.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnIncreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDecreaseThrottleMultiplier;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backward.started += instance.OnBackward;
                @Backward.performed += instance.OnBackward;
                @Backward.canceled += instance.OnBackward;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Headlight.started += instance.OnHeadlight;
                @Headlight.performed += instance.OnHeadlight;
                @Headlight.canceled += instance.OnHeadlight;
                @IncreaseThrottleMultiplier.started += instance.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.performed += instance.OnIncreaseThrottleMultiplier;
                @IncreaseThrottleMultiplier.canceled += instance.OnIncreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.started += instance.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.performed += instance.OnDecreaseThrottleMultiplier;
                @DecreaseThrottleMultiplier.canceled += instance.OnDecreaseThrottleMultiplier;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IGamepadControllerActions
    {
        void OnHeadlight(InputAction.CallbackContext context);
        void OnDirection(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
        void OnIncreaseThrottleMultiplier(InputAction.CallbackContext context);
        void OnDecreaseThrottleMultiplier(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnHeadlight(InputAction.CallbackContext context);
        void OnIncreaseThrottleMultiplier(InputAction.CallbackContext context);
        void OnDecreaseThrottleMultiplier(InputAction.CallbackContext context);
    }
}
