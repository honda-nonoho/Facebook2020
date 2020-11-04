using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private StoryPrefabController _StoryPrefab = null;   //StoryContent(Prefab)

    [SerializeField] private StoryContentController _StoryContentObject = null;

    int _Loop = 0;
    const string _FromPrefab = "Prefab/StoryContent";

    void Start()
    {
        Load();
    
        for(int i = 0; i < 4; i++)
        {
                _Loop++;
                var Prefab = Instantiate<StoryPrefabController>(_StoryPrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); //インスタンス生成
                Prefab.SetId(_Loop);
                Prefab.CallBuckButton += Test;
               
        }        
        
    }

    
    void Load()
    {
        
        _StoryPrefab = Resources.Load<StoryPrefabController>(_FromPrefab); //リソーシズロード (prefab)
        
    }

    public void Test()
    {
        Debug.Log("Test");

         _StoryContentObject.SetStory();                
         _StoryContentObject.gameObject.SetActive(true); 

    }

}
