using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;

public class Networker : MonoBehaviour
{
    public string BotIP;
    public int BotPort = 42069;
    public Logger log;
    public string[] sendMsgs;
    public System.Net.Sockets.TcpClient clientSocket;
    public bool connected;
    private NetworkStream stream;
    public InputController inp;
    public float forward;
    public float right;

    private void Awake()
    {
        sendMsgs = new string[] {
            "quit", // 0
            "headlight" // 1
        };
    }
    // Start is called before the first frame update
    void Start()
    {
        connected = false;
    }

    // Update is called once per frame
    void Update()
    {
        // right = inp.leftThumbStick.x;
    }

    public void connectedTrue()
    {
        connected = true;
        log.setDisconnectInteractable();
        log.denyTextInput();
    }

    public void connectedFalse()
    {
        connected = false;
        log.setConnectInteractable();
        log.allowTextInput();
    }

    public void connectToBot()
    {
        clientSocket = new System.Net.Sockets.TcpClient();
        log.logMsg(log.messages[0], log.normalColor);
        try
        {
            clientSocket.Connect(BotIP, BotPort);
            stream = clientSocket.GetStream();
        }
        catch(SocketException e)
        {
            log.logMsg(log.messages[3], log.warningColor);
            Debug.Log(e.Message);
            connectedFalse();
        }

        if(clientSocket != null && clientSocket.Connected)
        {
            connectedTrue();
            log.logMsg(log.messages[1], log.normalColor);
        }
    }

    public void disconnectFromBot()
    {
        if (clientSocket != null)
        {
            sendData(sendMsgs[0]);
            clientSocket.GetStream().Close();
            clientSocket.Close();
            log.logMsg(log.messages[5], log.alertColor);
        }
        connectedFalse();
    }
    
    public void toggelHeadLights()
    {
        log.logMsg(log.messages[7], log.normalColor);
        sendData(sendMsgs[1]);
    }

    public void sendData(string s)
    {
        if (!connected)
        {
            log.logMsg(log.messages[8], log.warningColor);
            return;
        }
        Byte[] data = System.Text.Encoding.ASCII.GetBytes(s);
        try {
            stream.Write(data, 0, data.Length);
            stream.Flush();
        }
        catch (Exception e)
        {
            disconnectFromBot();
            Debug.Log(e);
        }
    }
}
