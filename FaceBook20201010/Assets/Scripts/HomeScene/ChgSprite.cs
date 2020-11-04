using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChgSprite : MonoBehaviour
{
    public Sprite LogoBefore;
    public Sprite LogoPushAfter;

    [SerializeField] private Image _ButtonImage = null;

    private bool chFlg = false;

     public void changeSprite()
    {

        if(!chFlg){
        _ButtonImage.sprite = LogoBefore;
        chFlg = true;
        } else {
        _ButtonImage.sprite = LogoPushAfter;
        chFlg = false;
        }
    }
}

