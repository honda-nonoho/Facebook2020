using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShareController : MonoBehaviour
{
    [SerializeField] private GameObject _ShareObject = null; //表示したいobj
    [SerializeField] private GameObject _MainScrollViewObj = null; //非表示にしたいObj
    [SerializeField ] private Button _ShareButton = null;  

    public Animation anim;
    
    void Start()
    {
        //anim = GetComponent<Animation>();
        _ShareButton.onClick.AddListener(OnClickShareButton);
        
        
    }

     

    void OnClickShareButton()
    {
        Debug.Log("ShareButton");
        
        anim = GetComponent<Animation>();
        anim.Play();

        _ShareObject.transform.SetAsLastSibling();  //一番下(uGUIなら前面)
        _MainScrollViewObj.transform.SetAsFirstSibling(); //一番上(uGUIなら背面)

        
    }
}
