using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryContentController : MonoBehaviour
{
    public int id;

    [SerializeField] private GameObject _MainScrollViewObject = null; 
    //各UIの宣言=
    [SerializeField] private Text _StoryUserName = null;    //userName; 
    [SerializeField] private Image _StoryIconImage = null;
    [SerializeField] private Image _StoryContentImage = null; //storyPreviewImage

    [SerializeField] private Button _StoryCancelButton = null; 
    
    // Start is called before the first frame update
    void Start()
    {
         this.gameObject.SetActive(false);
        _StoryCancelButton.onClick.AddListener(OnClickStoryCancel);
    }

    void OnClickStoryCancel()
    {
        this.gameObject.SetActive(false);
        _MainScrollViewObject.gameObject.SetActive(true);
    }

    public void SetStory()
    { 
            int id = PlayerPrefs.GetInt("id");   

            string inputString = Resources.Load<TextAsset>("Json/faceBookJson").ToString();
            Debug.Log(inputString);
            TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);

        
        
            Debug.Log(inputJson);

            for(int i = 0; i < inputJson.data.Length; i++)
            {
                if(inputJson.data[i].id != id) continue;

                this._StoryUserName.text = inputJson.data[i].userName;
                
                Sprite inputSprite1 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].iconImage);
                _StoryIconImage.sprite = inputSprite1;

                 Sprite inputSprite2 = Resources.Load<Sprite>("Image/Story/" + inputJson.data[i].storyPreview);
                _StoryContentImage.sprite = inputSprite2;

            
                break;
            }

            Debug.Log(inputJson.data.Length); 
        
            Debug.Log(PlayerPrefs.GetInt("id"));

            
            
    }
}
