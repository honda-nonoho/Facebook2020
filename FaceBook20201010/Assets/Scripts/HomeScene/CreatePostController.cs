using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePostController : MonoBehaviour
{

    [SerializeField] private GameObject _CreatePostObj = null; //表示したいobj
    [SerializeField] private GameObject _MainScrollViewObj = null; //非表示にしたいObj
    [SerializeField ] private Button _CreatePostButton = null;  //投稿ボタン
    [SerializeField ] private Button _StatusButton = null;  //近況ボタン
    [SerializeField ] private Button _CancelButton = null; //CancelButton

    void Start()
    {
         this.gameObject.SetActive(false);
        _CreatePostButton.onClick.AddListener(OnClickCreatePostButton);
        _StatusButton.onClick.AddListener(OnClickStatusButton);
        _CancelButton.onClick.AddListener(OnClickCancelButton);
        
    }

    void OnClickCreatePostButton()
    {
        Debug.Log("CreatePostButton");
        _CreatePostObj.SetActive(true);
        _MainScrollViewObj.SetActive(false);
    }

    void OnClickStatusButton()
    {
        Debug.Log("StatusButton");
        _CreatePostObj.SetActive(true);
        _MainScrollViewObj.SetActive(false);
    }

    void OnClickCancelButton()
    {
        Debug.Log("Cancel");
        this.gameObject.SetActive(false);
        _MainScrollViewObj.SetActive(true);
    }
}
