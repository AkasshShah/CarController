using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public CarControls control;
    public Networker ntwk;
    public Vector2 leftThumbStick;

    private void OnEnable()
    {
        EnableController();
    }

    private void OnDisable()
    {
        control.GamepadController.Disable();
    }

    private void Awake()
    {
        leftThumbStick = Vector2.zero;
        control = new CarControls();
        control.GamepadController.Headlight.performed += ctx => inputHeadlightPerformed();
        control.GamepadController.Direction.performed += ctx => ntwk.right = ctx.ReadValue<Vector2>().x;
        control.GamepadController.Direction.canceled += ctx => ntwk.right = 0f;
        control.GamepadController.Acceleration.performed += ctx => ntwk.forward = ctx.ReadValue<Vector2>().y;
        control.GamepadController.Acceleration.canceled += ctx => ntwk.forward = 0f;
    }

    public void EnableController()
    {
        control.GamepadController.Enable();
    }
    
    private void inputHeadlightPerformed()
    {
        ntwk.toggelHeadLights();
    }
}
