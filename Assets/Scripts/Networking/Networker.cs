using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;

public class Networker : MonoBehaviour
{
    public string BotIP;
    public int BotPort = 42069;
    // public int BotPort = 99;
    public Logger log;
    public string[] sendMsgs;
    public System.Net.Sockets.TcpClient clientSocket;
    public bool connected;
    private NetworkStream stream;
    public InputController inp;
    public float forward;
    public float right;
    public Vector2 lastSent;

    private void Awake()
    {
        sendMsgs = new string[] {
            "quit", // 0
            "headlight", // 1
            "shutdown", // 2
            "reboot" // 3
        };
        lastSent = new Vector2(0f, 0f);
    }
    // Start is called before the first frame update
    void Start()
    {
        connected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (connected && (lastSent.x != right || lastSent.y != forward))
        {
            lastSent.x = right;
            lastSent.y = forward;
            string toSend = "{\"f\": " + forward.ToString() + ", \"r\": " + right.ToString() + "}";
            sendData(toSend);
        }
    }

    public void connectedTrue()
    {
        connected = true;
        log.setDisconnectInteractable();
        log.denyTextInput();
        log.connected(true);
    }

    public void connectedFalse()
    {
        connected = false;
        log.setConnectInteractable();
        log.allowTextInput();
        log.connected(false);
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
            log.inputKeyboardSelected();
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

    public void shutdwonBot()
    {
        if (clientSocket != null)
        {
            sendData(sendMsgs[2]);
            clientSocket.GetStream().Close();
            clientSocket.Close();
            log.logMsg(log.messages[9], log.alertColor);
        }
        connectedFalse();
    }

    public void rebootBot()
    {
        if (clientSocket != null)
        {
            sendData(sendMsgs[3]);
            clientSocket.GetStream().Close();
            clientSocket.Close();
            log.logMsg(log.messages[10], log.alertColor);
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
