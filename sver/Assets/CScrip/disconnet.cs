using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class disconnet : MonoBehaviour
{
    
   
    
    public void OnButton()
    {

        SocketClient.instance.ws.Send("��������");
        SocketClient.instance.ws.Close();
        //���� A ������? 
        Debug.Log("��������");
        
    }
}
