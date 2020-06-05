using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net;

public class Logger : MonoBehaviour
{
    public Networker networking;
    public InputController inputManager;
    public LogControl logControl;
    public string[] messages;
    public Color warningColor;
    public Color normalColor;
    public Color alertColor;
    public Button Connect;
    public Button Disconnect;
    public TMP_InputField IPInput;
    public TMP_InputField Forward;
    public TMP_InputField Right;
    public Button KeyboardInput;
    public Button ControllerInput;

    void Awake()
    {
        messages = new string[] {
            "Connecting...", // 0
            "Connected to control", // 1
            "Connected to video feed", // 2
            "Failed to Connect to Control", // 3
            "Unexpectedly Disconnected...", // 4
            "Disconnected...", // 5
            "Please provide valid IP", // 6
            "Headlights", // 7
            "Please Connect to car first" // 8
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        setConnectInteractable();
        allowTextInput();
        KeyboardInput.interactable = false;
        ControllerInput.interactable = false;
        Right.text = "0";
        Forward.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (networking.connected)
        {
            Right.text = networking.right.ToString();
            Forward.text = networking.forward.ToString();
        }
    }

    public void logMsg(string newLog, Color colour)
    {
        logControl.logMsg(newLog, colour);
    }

    public void setConnectInteractable()
    {
        Connect.interactable = true;
        Disconnect.interactable = false;
    }

    public void setDisconnectInteractable()
    {
        Connect.interactable = false;
        Disconnect.interactable = true;
    }

    public void allowTextInput()
    {
        IPInput.interactable = true;
    }

    public void denyTextInput()
    {
        IPInput.interactable = false;
    }

    public void clickedConnect()
    {
        IPAddress ip;
        if(IPAddress.TryParse(IPInput.text, out ip))
        {
            networking.BotIP = IPInput.text;
            networking.connectToBot();
        }
        else
        {
            logMsg(messages[6], warningColor);
        }
        
    }

    public void clickedDisconnect()
    {
        networking.disconnectFromBot();
    }

    public void inputKeyboardSelected()
    {
        inputManager.EnableKeyboard(true);
        inputManager.EnableController(false);
        KeyboardInput.interactable = false;
        ControllerInput.interactable = true;
    }

    public void inputControllerSelected()
    {
        inputManager.EnableKeyboard(false);
        inputManager.EnableController(true);
        KeyboardInput.interactable = true;
        ControllerInput.interactable = false;
    }
}
