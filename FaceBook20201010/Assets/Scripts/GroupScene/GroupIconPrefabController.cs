using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupIconPrefabController : MonoBehaviour
{
    public int id;
    [SerializeField] private Text _GroupName = null;
    [SerializeField] private Image _GroupIcon = null;

    void Start()
    {
        string inputString = Resources.Load<TextAsset>("Json/faceBook_GroupsJson").ToString();
        Debug.Log(inputString);
        TestJsonParent inputJson = JsonUtility.FromJson<TestJsonParent>(inputString);
     
        Debug.Log(inputJson);

        IdSet();

        for(int i = 0; i < inputJson.data.Length; i++)
        {
            if(inputJson.data[i].id != id) continue;

            this._GroupName.text = inputJson.data[i].groupName;


             Sprite inputSprite1 = Resources.Load<Sprite>("Image/Group/" + inputJson.data[i].groupIcon);
            _GroupIcon.sprite = inputSprite1;

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
