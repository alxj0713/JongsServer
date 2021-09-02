using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class Sand : MonoBehaviour
{
    public InputField iput;
    public Button send;
    
            
    

    private void Awake()
    {

        send.onClick.AddListener(OnClick);
        

    }

    void OnClick()
    {
        string str = iput.text;

        SocketClient.instance.ws.Send($"{str}");
    }
    

}
