using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PostDetailScrollViewController : MonoBehaviour
{
    [SerializeField] private GameObject _PostDetailScrollView = null;  
    private CommentPrefabController _CommentPrefab = null;

    private Dictionary<int,string> _UserNameDic = new Dictionary<int, string>(); 

    private Dictionary<int,string> _CommentDic = new Dictionary<int, string>(); 
    private Dictionary<int,string> _CommentPostingDic = new Dictionary<int, string>();



    int _Loop = 0;

    const string _FromCommentPrefab = "Prefab/CommentPrefab";
    void Start()
    {
        Load();
        
        for(int i = 0; i < 3; i++)
        {
            _Loop++;
            var index = i + 1;
            Debug.Log(index);
            var Sprite =  Resources.Load<Sprite>("Image/Comment/CommentIcon/" + index.ToString());  //PostのResource
            var Prefab  = Instantiate<CommentPrefabController>(_CommentPrefab, Vector3.zero, Quaternion.identity, _PostDetailScrollView.transform); //インスタンス生成

            Prefab.SetPrefab(Sprite);
            Prefab.SetId(_Loop);

            
            
        }
    }

    void Load()
    {
        _CommentPrefab = Resources.Load<CommentPrefabController>(_FromCommentPrefab);  //リソーシズ
    }
}
