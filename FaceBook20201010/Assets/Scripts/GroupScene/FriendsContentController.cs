using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendsContentController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _UserName = null;    //userName; 
    [SerializeField] private Image _IconImage = null;    // public string iconImage; 
    [SerializeField] private Text _PostingTimeText = null;    // public string postingTimeText; //XX時間前・
    [SerializeField] private Text _PostText = null;    // public string postText;  
    [SerializeField] private Image _PostImage = null;    // public string postImage;
    [SerializeField] private Text _StampButtonText = null;    // public string stampButtonText;  //あなた、他XXXX人
    [SerializeField] private Text _PostDetailText = null;    // public string postDetailText;   //コメントXX件　　シェアXX件  
   
   //LikeButtonの実装

    public Sprite LogoLike; //いいねの押す前
    public Sprite LogoPushLike; //いいね押した後

    [SerializeField] private Image _LikeButtonImage = null;
    private bool change = false;  //ボタンを押したら戻る、の宣言


    void Start()
    {
        string inputString = Resources.Load<TextAsset>("Json/faceBook_FriendsJson").ToString();
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
           

            Sprite inputSprite1 = Resources.Load<Sprite>("Image/Friends/" + inputJson.data[i].iconImage);
            _IconImage.sprite = inputSprite1;

            Sprite inputSprite2 = Resources.Load<Sprite>("Image/Friends/" + inputJson.data[i].postImage);
            _PostImage.sprite = inputSprite2;

        
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

    public void OnClickLike()  //ボタンを押した時の処理
    {
        if(!change)
        {
            _LikeButtonImage.sprite = LogoLike; //押したら画像が変わる処理
            change = true;
        }else{
            _LikeButtonImage.sprite = LogoPushLike;  //もう一回押したら戻る
            change = false;
        }
    }

}
