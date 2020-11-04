using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeScrollViewController : MonoBehaviour
{
    
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private TimeLinePrefabController _TimeLinePrefab = null;   //TimeLine(Prefab)

    [SerializeField] private PostDetailController _PostDetailObject = null;
    [SerializeField] private AccountPageController _AccountPageObject = null;


    int _Loop = 0;
    const string _FromPrefab = "Prefab/TimeLineContent";
    
    void Start()
    {
        Load();
    
        for(int i = 0; i < 4; i++)
        {
                _Loop++;
                var Prefab = Instantiate<TimeLinePrefabController>(_TimeLinePrefab, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); //インスタンス生成
                Prefab.SetId(_Loop);
                Prefab.CallBuckButton += Test;
                Prefab.CallBuckButton2 += Test2;
               
        }        
    
    }
    void Load()
    {
        Debug.Log("Load");
        _TimeLinePrefab = Resources.Load<TimeLinePrefabController>(_FromPrefab); //リソーシズロード (prefab)
      
    }

    public void Test()
    {
        Debug.Log("Test");

         _PostDetailObject.SetDetail();                
         _PostDetailObject.gameObject.SetActive(true); 

       
    }

    public void Test2()
    {
        Debug.Log("Test2");
        _AccountPageObject.SetPage();                
        _AccountPageObject.gameObject.SetActive(true); 

    }

}
