using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    public CarControls control;
    public Networker ntwk;
    public Slider ThrottleMultiplier;

    private void OnEnable()
    {
        EnableController(false);
        EnableKeyboard(false);
    }

    private void OnDisable()
    {
        control.GamepadController.Disable();
    }

    private void Awake()
    {
        control = new CarControls();

        // Gamepad Controls
        control.GamepadController.Headlight.performed += ctx => ntwk.toggelHeadLights();
        control.GamepadController.Direction.performed += ctx => ntwk.right = ctx.ReadValue<Vector2>().x;
        control.GamepadController.Direction.canceled += ctx => ntwk.right = 0f;
        control.GamepadController.Acceleration.performed += ctx => ntwk.forward = ctx.ReadValue<Vector2>().y * ThrottleMultiplier.value;
        control.GamepadController.Acceleration.canceled += ctx => ntwk.forward = 0f;

        // Keyboard Controls
        control.Keyboard.Forward.performed += ctx => ntwk.forward = ThrottleMultiplier.value;
        control.Keyboard.Forward.canceled += ctx => ntwk.forward = 0f;
        control.Keyboard.Backward.performed += ctx => ntwk.forward = -1f * ThrottleMultiplier.value;
        control.Keyboard.Backward.canceled += ctx => ntwk.forward = 0f;
        control.Keyboard.Right.performed += ctx => ntwk.right = 1f;
        control.Keyboard.Right.canceled += ctx => ntwk.right = 0f;
        control.Keyboard.Left.performed += ctx => ntwk.right = -1f;
        control.Keyboard.Left.canceled += ctx => ntwk.right = 0f;
    }

    public void EnableController(bool torf)
    {
        if (torf)
        {
            control.GamepadController.Enable();
        }
        else
        {
            control.GamepadController.Disable();
        }
    }

    public void EnableKeyboard(bool torf)
    {
        if (torf)
        {
            control.Keyboard.Enable();
        }
        else
        {
            control.Keyboard.Disable();
        }
    }
}
