using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Txtdown : MonoBehaviour
{
    static public string data;
    public Text tttexttt;
    

    private void Update()
    {
        if (data != null)
        {
            tttexttt.text += $"{data}\n";
        }
    }
}
