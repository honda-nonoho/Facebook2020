using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StoryPrefabController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _UserName = null;    //userName; 
    [SerializeField] private Image _IconImage = null;
    [SerializeField] private Image _StoryPreviewImage = null;

    [SerializeField] private Button _StoryContentButton = null;

    public Action CallBuckButton = null;  //コールバック


        void Start()
    {
        _StoryContentButton.onClick.AddListener(OnClickStoryContentButton);



        string inputString = Resources.Load<TextAsset>("Json/faceBookJson").ToString();
        Debug.Log(inputString);
        TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);
     
        Debug.Log(inputJson);

        IdSet();

        for(int i = 0; i < inputJson.data.Length; i++)
        {
            if(inputJson.data[i].id != id) continue;

            this._UserName.text = inputJson.data[i].userName;


             Sprite inputSprite1 = Resources.Load<Sprite>("Image/TimeLine/" + inputJson.data[i].iconImage);
            _IconImage.sprite = inputSprite1;

             Sprite inputSprite2 = Resources.Load<Sprite>("Image/Story/" + inputJson.data[i].storyPreview);
            _StoryPreviewImage.sprite = inputSprite2;








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

    void OnClickStoryContentButton()
    {
        Debug.Log(id);

        PlayerPrefs.SetInt("id", id);
        Debug.Log("GetInt: " + PlayerPrefs.GetInt("id"));
        if(CallBuckButton != null)
        {
          CallBuckButton.Invoke();
        }
        Debug.Log("OnStoryContentButton");
    }
}
