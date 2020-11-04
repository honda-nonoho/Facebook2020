using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InformationScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _ScrollViewContent = null;
    private InformationContentController _InformationContent = null;

    int _Loop = 0;
    const string _FromPrefab = "Prefab/InformationContent";
    // Start is called before the first frame update
    void Start()
    {
         Load();
    
        for(int i = 0; i < 4; i++)
        {
                _Loop++;
                var Prefab = Instantiate<InformationContentController>(_InformationContent, Vector3.zero, Quaternion.identity, _ScrollViewContent.transform); //インスタンス生成
                Prefab.SetId(_Loop);
                // Prefab.CallBuckButton += Test;
               
        }        
        
    }

    void Load()
    {
         Debug.Log("Load");
        _InformationContent = Resources.Load<InformationContentController>(_FromPrefab); //リソーシズロード (prefab)
        
    }
        
}


