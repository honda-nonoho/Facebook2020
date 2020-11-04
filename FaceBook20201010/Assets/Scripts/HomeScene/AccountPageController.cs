using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountPageController : MonoBehaviour
{
    public int id;
    [SerializeField] private GameObject _MainScrollViewObject = null;


    //各UIの宣言
    //各UIの宣言
    [SerializeField] private Text _PlaceHolder = null;    //Header>placeHolder
    [SerializeField] private Image _HeaderImage = null;    //Image>Header>Json
    [SerializeField] private Image _IconImage = null;    //Image>Header>Json
    [SerializeField] private Text _OccupationText = null;    
    [SerializeField] private Text _UserName = null;    
    [SerializeField] private Text _PeopleLikeText = null; 
    [SerializeField] private Text _TopFansText = null;  
    [SerializeField] private Text _TopFansLogoText = null;  
    [SerializeField] private Text _WebText = null; 
    [SerializeField] private Text _OccupationAboutText = null; 
    //戻るボタン
    [SerializeField] private Button _BuckHomeButton = null; 

        void Start()
    {
        this.gameObject.SetActive(false);
        _BuckHomeButton.onClick.AddListener(OnClickBuckHomeButton);
        
    }
    void OnClickBuckHomeButton()
    {
        this.gameObject.SetActive(false);
        _MainScrollViewObject.gameObject.SetActive(true);

    }

    public void SetPage()
    { 
            int id = PlayerPrefs.GetInt("id");   

            string inputString = Resources.Load<TextAsset>("Json/faceBookJson").ToString();
            Debug.Log(inputString);
            TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);

        
        
            Debug.Log(inputJson);

            for(int i = 0; i < inputJson.data.Length; i++)
            {
                if(inputJson.data[i].id != id) continue;

                this._PlaceHolder.text = inputJson.data[i].userName;
                this._OccupationText.text = inputJson.data[i].occupationText;
                this._UserName.text = inputJson.data[i].userName;
                this._PeopleLikeText.text = inputJson.data[i].peopleLikeText;
                this._TopFansText.text = inputJson.data[i].topFansText;
                this._TopFansLogoText .text = inputJson.data[i].topFansText;
                this._WebText.text = inputJson.data[i].webText;
                this._OccupationAboutText.text = inputJson.data[i].occupationText;


                
                Sprite inputSprite1 = Resources.Load<Sprite>("Image/Header/" + inputJson.data[i].headerImage);
                _HeaderImage.sprite = inputSprite1;

                Sprite inputSprite2 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].iconImage);
                _IconImage.sprite = inputSprite2;

            
                break;
            }

            Debug.Log(inputJson.data.Length); 
        
            Debug.Log(PlayerPrefs.GetInt("id"));

            
            
    }

    
}
