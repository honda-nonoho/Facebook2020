using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using UnityEditor;
using DG.Tweening;
using UnityEngine.SceneManagement;

namespace Common
{
    public class FooterController : MonoBehaviour
    {
        [SerializeField] private Button _HomeButton = null;
        [SerializeField] private Button _WatchButton = null;
        [SerializeField] private Button _MypageButton = null;
        [SerializeField] private Button _GroupButton = null;
        [SerializeField] private Button _InformationButton = null;
        [SerializeField] private Button _MenuButton = null;

        //[SerializeField] private Image _SlidebarImage = null;

        [SerializeField] private SlideController _SlideController = null;  //SlideControllerの宣言

        private SpriteAtlas _FooterAtlas = null;  //収納一回
        private Dictionary<string, Image> _ButtonImages = new Dictionary<string, Image>(); //Dictionaryの配列でImgをセットさせる。毎回押した時にGetComponentをいちいちせずに取り出せるように

        public void Initialize()  //Headerと同じタイミンで初期化するためイニシャライズする
        {
            if(_HomeButton)
            {
                _HomeButton.onClick.AddListener(OnClickHomeButton);
                _ButtonImages.Add("home",_HomeButton.GetComponent<Image>());
            }

             if(_WatchButton)
            {
                _WatchButton.onClick.AddListener(OnClickWatchButton);
                _ButtonImages.Add("watch",_WatchButton.GetComponent<Image>());
                
            }

             if(_MypageButton)
            {
                _MypageButton.onClick.AddListener(OnClickMypageButton);
                _ButtonImages.Add("mypage",_MypageButton.GetComponent<Image>());
            }
             if(_GroupButton)
            {
                 _GroupButton.onClick.AddListener(OnClickGroupButton);
                _ButtonImages.Add("group",_GroupButton.GetComponent<Image>());
            }
             if(_InformationButton)
            {
                _InformationButton.onClick.AddListener(OnClickInformationButton);
                _ButtonImages.Add("information",_InformationButton.GetComponent<Image>());
            }

            if(_MenuButton)
            {
                _MenuButton.onClick.AddListener(OnClickMenuButton);
                _ButtonImages.Add("menu",_MenuButton.GetComponent<Image>());
            }

            
        }

        public void OnAssetLoad()
        {
            //SoriteAtlasをダウンロード
             _FooterAtlas = AssetDatabase.LoadAssetAtPath<SpriteAtlas>("Assets/atlas/Footer.spriteatlas");
        }

        void OnClickHomeButton()
        {
            this.SetButtonImage("home");
            _SlideController.PlaySlide(1);
            Debug.Log("OnClickHomeButton");
            SceneManager.LoadScene("HomeScene");
         
        }
        
        void OnClickWatchButton() //-187(x)
        {
            this.SetButtonImage("watch");
            _SlideController.PlaySlide(2);
            Debug.Log("OnClickWatchButton");
            SceneManager.LoadScene("WatchScene");

        }

        void OnClickMypageButton() //-61(x)
        {
            this.SetButtonImage("mypage");
            _SlideController.PlaySlide(3);
            Debug.Log("OnClickMypageButton");
            SceneManager.LoadScene("MypageScene");
            
        }
        void OnClickGroupButton()//63(x)
        {
            this.SetButtonImage("group");
            _SlideController.PlaySlide(4);
            Debug.Log("OnClickGroupButton");
            SceneManager.LoadScene("GroupScene");
            
        }
        void OnClickInformationButton()//188(x)
        {
            this.SetButtonImage("information");
            _SlideController.PlaySlide(5);
            Debug.Log("OnClickInformationButton");
            SceneManager.LoadScene("InformationScene");
        
        }

        void OnClickMenuButton()//313(x)
        {
            this.SetButtonImage("menu");
            _SlideController.PlaySlide(6);
            Debug.Log("OnClickMenuButton");
            SceneManager.LoadScene("MenuScene");
                       
    
        }
        
        private void SetButtonImage(string onButtonName)

        {
            foreach(KeyValuePair<string, Image> pair in _ButtonImages)
            {
                string name = "";

                if(onButtonName == pair.Key)
                {
                    name = string.Format("footer_{0}_on", pair.Key);
                }else
                {
                    name = string.Format("footer_{0}_off", pair.Key);
                }

                pair.Value.sprite = _FooterAtlas.GetSprite(name);
            }
        }
    }
}

    



        
        
