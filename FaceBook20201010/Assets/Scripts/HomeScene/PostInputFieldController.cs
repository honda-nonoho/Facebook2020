using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostInputFieldController : MonoBehaviour
{
    public InputField inputField;
    private Text text;
    [SerializeField] private GameObject _MainScrollViewContent = null; //MainScrollView>Content
    

    private MyPostContentController _MyPostContent = null; //MyPostContent(Prefab)
    const string _From = "Prefab/MyPostContent";
    //送信ボタン
    [SerializeField] private Button _PostButton = null; //投稿完了

    [SerializeField] private GameObject _CreatePostObj = null; //非表示
    [SerializeField] private GameObject _MainScrollViewObj = null; //表示
    void Start()
    {
        _PostButton.onClick.AddListener(OnClickPostDone); //投稿完了
        if(inputField.text != "")
        {
            OnClickPostDone();
        }
    }

    void OnClickPostDone()
    {
        Debug.Log(inputField.text);
        Load();
        inputField = inputField.GetComponent<InputField> ();
        inputField.text = ""; //inputField内のテキストをボタン送信後に空にする

         _CreatePostObj.SetActive(false);
         _MainScrollViewObj.SetActive(true);

    }

    void Load()
    {

        //ResourcesLoad
        _MyPostContent = Resources.Load<MyPostContentController>(_From);
        //Instantiate
        var Prefab  = Instantiate<MyPostContentController>(_MyPostContent, Vector3.zero, Quaternion.identity, _MainScrollViewContent.transform);
        Prefab.transform.SetSiblingIndex(3);
        
        Prefab.SetText(inputField.text); 

        Debug.Log("Load");
    }

    
}
