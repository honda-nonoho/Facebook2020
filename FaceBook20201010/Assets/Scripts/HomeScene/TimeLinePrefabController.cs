using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeLinePrefabController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _UserName = null;    //userName; 
    [SerializeField] private Image _IconImage = null;    // public string iconImage; 
    [SerializeField] private Text _PostingTimeText = null;    // public string postingTimeText; //XX時間前・
    [SerializeField] private Text _PostText = null;    // public string postText;  
    [SerializeField] private Image _PostImage = null;    // public string postImage;
    [SerializeField] private Text _StampButtonText = null;    // public string stampButtonText;  //あなた、他XXXX人
    [SerializeField] private Text _PostDetailText = null;    // public string postDetailText;   //コメントXX件　　シェアXX件  
    [SerializeField] private Image _CommentIconImage = null;    // public string commentIconImage
    [SerializeField] private Text _CommentText = null;    // public string commentText;


    [SerializeField] private Button _PostDetailButton = null;
    [SerializeField] private Button _PostDetailTextButton = null;

    [SerializeField] private Button _IconButton = null;



    //LikeButtonの実装

    public Sprite LogoLike; //いいねの押す前
    public Sprite LogoPushLike; //いいね押した後
    private bool change = false;  //ボタンを押したら戻る、の宣言



    public Action CallBuckButton = null;  //コールバック
    public Action CallBuckButton2 = null;  


    void Start()
    {
        _PostDetailButton.onClick.AddListener(OnClickPostDetailButton);
        _PostDetailTextButton.onClick.AddListener(OnClickPostDetailTextButton);
        _IconButton.onClick.AddListener(OnClickAccountPage);

        string inputString = Resources.Load<TextAsset>("Json/faceBookJson").ToString();
        Debug.Log(inputString);
        TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);

        
     
        Debug.Log(inputJson);

        IdSet();

        

        for(int i = 0; i < inputJson.data.Length; i++)
        {
            if(inputJson.data[i].id != id) continue;

            this._UserName.text = inputJson.data[i].userName;
            this._PostingTimeText.text = inputJson.data[i].postingTimeText;
            this._PostText.text = inputJson.data[i].postText;
            this._StampButtonText.text = inputJson.data[i].stampButtonText;
            this._PostDetailText.text = inputJson.data[i].postDetailText;
            this._CommentText.text = inputJson.data[i].commentText;

            Sprite inputSprite1 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].iconImage);
            _IconImage.sprite = inputSprite1;

            Sprite inputSprite2 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].postImage);
            _PostImage.sprite = inputSprite2;

            Sprite inputSprite3 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].commentIconImage);
            _CommentIconImage.sprite = inputSprite3;

             break;
        }
    }

    void IdSet()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("SetInt: " + PlayerPrefs.GetInt("id"));
    }
    public void SetId(int dataId)
    {

        id = dataId;
    }

    void OnClickPostDetailButton()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton != null)
        {
          CallBuckButton.Invoke();
        }
        Debug.Log("OnPostDetailButton");

    }

    void OnClickPostDetailTextButton()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton != null)
        {
          CallBuckButton.Invoke();
        }
        Debug.Log("OnClickPostDetailTextButton");

    }

    void OnClickAccountPage()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton2 != null)
        {
          CallBuckButton2.Invoke();
        }
        Debug.Log("OnClickAccountPage");

    }

    public void OnClickLike()  //ボタンを押した時の処理
    {
        if(!change)
        {
            this.gameObject.GetComponent<Image> ().sprite = LogoLike; //押したら画像が変わる処理
            change = true;
        }else{
            this.gameObject.GetComponent<Image> ().sprite = LogoPushLike;  //もう一回押したら戻る
            change = false;
        }
    }


}
