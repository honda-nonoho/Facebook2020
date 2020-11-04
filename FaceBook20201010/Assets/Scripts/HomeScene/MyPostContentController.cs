using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyPostContentController : MonoBehaviour
{
    public Text _OutputText;  //inputFieldから受け取って表示されるテキスト
    
     public void SetText(string text)  //Textはstring
    {
        
        Debug.Log(text);
        Debug.Log(_OutputText);
        _OutputText.text = text;  
    }
}
