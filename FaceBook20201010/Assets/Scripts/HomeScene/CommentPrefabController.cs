using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommentPrefabController : MonoBehaviour
{
    public int id;
    [SerializeField] private Image _CommentIconImage = null;
    // [SerializeField] private Text _CommentUserName = null;
    // [SerializeField] private Text _CommentText = null;
    //[SerializeField] private Text _CommentPostingText = null;  //PostingTimeText

    public void SetId(int dataId)
    {
        id = dataId;  
    }
    
    public void SetPrefab(Sprite sprite)
    {
       _CommentIconImage.sprite = sprite;
       
    }
      
      

}
