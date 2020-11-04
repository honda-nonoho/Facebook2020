using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationContentController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _UserName = null;
    [SerializeField] private Text _PostingTimeText = null;
    [SerializeField] private Image _IconImage = null;
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
            
            Sprite inputSprite1 = Resources.Load<Sprite>("Image/Friends/" + inputJson.data[i].iconImage);
            _IconImage.sprite = inputSprite1;
        
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

}
