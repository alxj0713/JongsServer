using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;

public class disconnet : MonoBehaviour
{
    
   
    
    public void OnButton()
    {

        SocketClient.instance.ws.Send("立加辆丰");
        SocketClient.instance.ws.Close();
        //郴哪 A 立げ加? 
        Debug.Log("立加辆丰");
        
    }
}
