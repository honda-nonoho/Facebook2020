using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostDetailController : MonoBehaviour
{  
    public int id;

    [SerializeField] private GameObject _MainScrollViewObject = null; 

    //各UIの宣言
    [SerializeField] private Text _HeaderName = null;    //headerName;   [TWICE's Post]
    [SerializeField] private Text _PostText = null;    // public string postText;  
    [SerializeField] private Image _PostImage = null;    // public string postImage;
    [SerializeField] private Text _StampButtonText = null;    
    [SerializeField] private Text _ShareText = null;    
    
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

    

    public void SetDetail()
    { 
            int id = PlayerPrefs.GetInt("id");   

            string inputString = Resources.Load<TextAsset>("Json/faceBookJson").ToString();
            Debug.Log(inputString);
            TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);

        
        
            Debug.Log(inputJson);

            for(int i = 0; i < inputJson.data.Length; i++)
            {
                if(inputJson.data[i].id != id) continue;

                this._HeaderName.text = inputJson.data[i].headerName;
                this._PostText.text = inputJson.data[i].postText;
                this._StampButtonText.text = inputJson.data[i].stampButtonText;
                this._ShareText.text = inputJson.data[i].shareText;
                
                Sprite inputSprite1 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].postImage);
                _PostImage.sprite = inputSprite1;

            
                break;
            }

            Debug.Log(inputJson.data.Length); 
        
            Debug.Log(PlayerPrefs.GetInt("id"));

            
            
    }

    
}
