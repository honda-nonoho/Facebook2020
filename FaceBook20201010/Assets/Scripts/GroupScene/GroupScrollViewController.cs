using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupScrollViewController : MonoBehaviour
{

    [SerializeField] private GameObject _GroupScrollViewContent = null;
    private GroupIconPrefabController _GroupIconPrefab = null;

    int _Loop = 0;
    const string _From = "Prefab/GroupIconPrefab";

        void Start()
    {
        Load();
    
        for(int i = 0; i < 3; i++)
        {
                _Loop++;
                var Prefab = Instantiate<GroupIconPrefabController>(_GroupIconPrefab, Vector3.zero, Quaternion.identity, _GroupScrollViewContent.transform); //インスタンス生成
                Prefab.SetId(_Loop);
                //Prefab.CallBuckButton += Test;
               
        }        
        
    }
    void Load()
    {
         _GroupIconPrefab = Resources.Load<GroupIconPrefabController>(_From); //リソーシズロード (prefab)
    }
}
