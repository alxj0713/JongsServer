using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

public class NewBehaviourScript : MonoBehaviour
{
    string url = "ws://localhost";
    int port = 32000;

    // import ws from "ws";

    WebSocket ws;

    private void Awake()
    {
        // const wsService = new WebSocketServer();
        ws = new WebSocket($"{url}:{port}");
        ws.Connect();

        ws.Send("stpuw");
    }
}
