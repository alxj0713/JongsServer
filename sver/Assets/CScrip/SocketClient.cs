using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class SocketClient : MonoBehaviour
{
    static public SocketClient instance;

    public string url;
    public int port;
    public InputField Ip;
    public InputField fort;


    // import ws from "ws";

    public WebSocket ws;


    private void Awake()
    {
        instance = this;
        
    }


    public void fuckingButton()
    {
        ws = new WebSocket($"ws://{SocketClient.instance.Ip.text}:{SocketClient.instance.fort.text}");


        ws.Connect();
        Debug.Log($"{Ip.text}:{fort.text}肺 立加 窍看嚼聪促.");
        ws.Send("蜡历 立加");
        ws.OnMessage += (sender,e ) =>
        {
            ReceiveData( (WebSocket)sender, e);
        };
        

    }

    private void ReceiveData(WebSocket sender, MessageEventArgs e)
    {
        Txtdown.data = e.Data;
    }


}
