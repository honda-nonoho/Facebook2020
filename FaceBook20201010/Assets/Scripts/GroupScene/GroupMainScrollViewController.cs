using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupMainScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null; //scrollViewContent
    private FriendsContentController _FriendsContent = null;   //TimeLine(Prefab)

    int _Loop = 0;
    const string _FromPrefab = "Prefab/FriendsContent";
    


    // Start is called before the first frame update
    void Start()
    {
        Load();
    
        for(int i = 0; i < 4; i++)
        {
                _Loop++;
                var Prefab = Instantiate<FriendsContentController>(_FriendsContent, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); //インスタンス生成
                Prefab.SetId(_Loop);
                // Prefab.CallBuckButton += Test;
               
        }        
        
    }

    void Load()
    {
         Debug.Log("Load");
        _FriendsContent = Resources.Load<FriendsContentController>(_FromPrefab); //リソーシズロード (prefab)
        
    }
}
